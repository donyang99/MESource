using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.mesCommand;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Services.Description;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Net;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WebApi
{
    public class Instance : ICmdWebApiInstance
    {
        public enum WebApiMethod { GET, POST }//, PUT, DELETE }

        //Call by External System by WebApi
        public string ExecuteMesCmd(IMessageGuard serviceHost, string msgFormat, string message)
        {
            Command cmd = Util.JsonToMesCommand(message);
            ItemValue iv = null;
            if (cmd.GetArgument("requestClientAdress") == null)
            {
                iv = new ItemValue() { name = "requestClientAdress", Value = requestClientAdress() };
                cmd.Arguments.Add(iv);
            }

            string clientIp = cmd.GetArgumentValue("requestClientAdress");
            txnUtil.hostname = clientIp;

            dynamic dMsgGuard = idv.messageService.serviceHost.Client;
            dMsgGuard.setAppId("WebApiClientIP:" + clientIp);

            cmd.doTxn();

            if (string.Equals(cmd.result, "PASS"))
            {
                try
                {
                    foreach (txnBase txn in cmd.publishTxn)
                        publishTxn_(txn);

                    cmd.publishTxn.Clear();
                }
                catch { }
            }

            if (iv != null)
                cmd.Arguments.Remove(iv);

            string reply = "";
            if (cmd.ReturnJsonObjectFormat)
                reply = JsonConvert.SerializeObject(cmd.JsonObject);
            else
                reply = Util.MesMessageToJson(cmd, cmd.ReplyMode);
            return reply;
        }

        void publishTxn_(txnBase txn)
        {
            foreach (itemBase item in txn.Items)
            {
                try
                {
                    messageBase msg = item as messageBase;
                    if (msg == null || msg.To.Equals("")) continue;
                    msg.send();
                }
                catch { }
            }
            foreach (txnBase subTxn in txn.publishTxn)
                publishTxn_(subTxn);
        }

        internal static string requestClientAdress()
        {
            try
            {
                HttpRequestMessageProperty requestProperty = OperationContext.Current.IncomingMessageProperties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
                if (requestProperty != null && !string.IsNullOrWhiteSpace(requestProperty.Headers["X-Real-IP"]))
                    return requestProperty.Headers["X-Real-IP"];

                string ip = (OperationContext.Current.IncomingMessageProperties["System.ServiceModel.Channels.RemoteEndpointMessageProperty"] as RemoteEndpointMessageProperty).Address;
                //var remoteEndpointMessageProperty = OperationContext.Current.RequestContext.RequestMessage.Properties[RemoteEndpointMessage] as System.ServiceModel.Channels.RemoteEndpointMessageProperty;
                //if (remoteEndpointMessageProperty.Address.Equals("::1"))
                //    return "127.0.0.1";
                //else
                //    return remoteEndpointMessageProperty.Address;
                if (ip.Equals("::1"))
                    ip = "127.0.0.1";
                return ip;
            }
            catch { }
            return "127.0.0.1";
        }

        //MES Notice Message To External System  <========================================================在此實現MES廣播訊息要送給外部系統
        public void SendMsgToEq(messageBase msgItem, ref string message, string to)
        {
            switch (msgItem.GetType().Name)
            {
                case "Lot":
                    break;
                case "Equipment":
                    break;
                case "notifyCollection":
                    break;
                case "Command":
                    break;
                default:
                    return;
            }
            message = Util.MesMessageToJson(msgItem);
        }

        public static string SendMessageToWebApi(string url, params string[] parms)
        {
            return SendMessageToWebApi(url, 0, parms);
        }
        public static string SendMessageToWebApi(string url, int method, params string[] parms)
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < parms.Length; i = i + 2)
            {
                KeyValuePair<string, string> kv = new KeyValuePair<string, string>(parms[i], parms[i + 1]);
                list.Add(kv);
            }
            return SendMessageToWebApi(url, (WebApiMethod)method, list.ToArray());
        }
        public static string SendMessageToWebApi(string url, WebApiMethod method, params KeyValuePair<string, string>[] parms)
        {
            try
            {
                if (method == WebApiMethod.POST)
                    return SendMessageByPOST(url, parms);
                else if (method == WebApiMethod.GET)
                    return SendMessageByGET(url, parms);
                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        static string SendMessageByPOST(string url, params KeyValuePair<string, string>[] parms)
        {
            System.Net.HttpWebRequest client = System.Net.HttpWebRequest.CreateDefault(new Uri(url)) as System.Net.HttpWebRequest;
            client.Method = "POST";
            client.ContentType = "application/x-www-form-urlencoded";
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> kv in parms)
                list.Add(kv.Key + "=" + kv.Value);
            byte[] bs = Encoding.UTF8.GetBytes(string.Join("&", list.ToArray()));
            client.ContentLength = bs.Length;

            using (System.IO.Stream reqStream = client.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
            }

            using (System.Net.WebResponse wr = client.GetResponse())
            {
                //在這裡對接收到的頁面內容進行處理
                using (System.IO.Stream resStream = wr.GetResponseStream())
                {
                    List<byte> lstByte = new List<byte>();
                    while (true)
                    {
                        int b = resStream.ReadByte();
                        if (b == -1) break;
                        lstByte.Add((byte)b);
                    }
                    string sResponse = Encoding.UTF8.GetString(lstByte.ToArray());
                    return sResponse;
                }
            }
        }
        static string SendMessageByGET(string url, params KeyValuePair<string, string>[] parms)
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> kv in parms)
                list.Add(kv.Key + "=" + kv.Value);
            url += "?" + string.Join("&", list.ToArray());
            System.Net.HttpWebRequest client = System.Net.HttpWebRequest.CreateDefault(new Uri(url)) as System.Net.HttpWebRequest;
            client.Method = "GET";
            client.ContentType = "application/x-www-form-urlencoded";

            using (System.Net.WebResponse wr = client.GetResponse())
            {
                //在這裡對接收到的頁面內容進行處理
                using (System.IO.Stream resStream = wr.GetResponseStream())
                {
                    List<byte> lstByte = new List<byte>();
                    while (true)
                    {
                        int b = resStream.ReadByte();
                        if (b == -1) break;
                        lstByte.Add((byte)b);
                    }
                    string sResponse = Encoding.UTF8.GetString(lstByte.ToArray());
                    return sResponse;
                }
            }
        }
    }

    public static class Util
    {
        public static Command JsonToMesCommand(string json)
        {
            Command cmd = new Command();
            JObject root = null;
            try
            {
                object o = JsonConvert.DeserializeObject(json);
                if (o.GetType() == typeof(string))
                    root = JsonConvert.DeserializeObject(o.ToString()) as JObject;
                else
                    root = o as JObject;
            }
            catch (Exception ex)
            {
                logError(ex, json);
            }
            JToken jt = null;
            root.TryGetValue("name", out jt);
            if (jt != null) cmd.name = (jt as JValue).Value.ToString();
            root.TryGetValue("sysid", out jt);
            if (jt != null) cmd.sysid = (jt as JValue).Value.ToString();
            root.TryGetValue("to", out jt);
            if (jt != null) cmd.To = (jt as JValue).Value.ToString();
            root.TryGetValue("assemblyName", out jt);
            if (jt != null) cmd.AssemblyName = (jt as JValue).Value.ToString();
            root.TryGetValue("className", out jt);
            if (jt != null) cmd.ClassName = (jt as JValue).Value.ToString();
            root.TryGetValue("errMessage", out jt);
            if (jt != null) cmd.errMessage = (jt as JValue).Value.ToString();
            root.TryGetValue("result", out jt);
            if (jt != null) cmd.result = (jt as JValue).Value.ToString();
            root.TryGetValue("sender", out jt);
            if (jt != null) cmd.Sender = (jt as JValue).Value.ToString();
            root.TryGetValue("txnActor", out jt);
            if (jt != null) cmd.txnActor = (TransactionActor)Convert.ToInt32((jt as JValue).Value);
            root.TryGetValue("replyMode", out jt);
            if (jt != null) cmd.ReplyMode = (WebReplyMode)Convert.ToInt32((jt as JValue).Value);

            root.TryGetValue("arguments", out jt);
            if (jt is JObject)
            {
                foreach (JProperty jp in (jt as JObject).Properties())
                {
                    object o = jTokenToItemValue(jp.Value);
                    if (o is ItemValue)
                    {
                        ItemValue iv = o as ItemValue;
                        iv.name = jp.Name;
                        cmd.Arguments.Add(iv);
                    }
                    else
                        cmd.AddArgument(jp.Name, o);
                }
            }

            root.TryGetValue("items", out jt);
            if (jt is JObject)
            {
                foreach (JProperty jp in (jt as JObject).Properties())
                {
                    object o = jTokenToItemValue(jp.Value);
                    if (o is ItemValue)
                    {
                        ItemValue iv = o as ItemValue;
                        iv.name = jp.Name;
                        cmd.AddItem(iv);
                    }
                    else
                        cmd.AddItem(jp.Name, o);
                }
            }
            else if (jt is JArray)
            {
                foreach (JToken t in (jt as JArray))
                {
                    object o = jTokenToItemValue(t);
                    if (o is ItemValue)
                        cmd.AddItem(o as ItemValue);
                    else
                        cmd.AddItem("", o);
                }
            }
            return cmd;
        }
        static object jTokenToItemValue(JToken token)
        {
            if (token is JValue)
                return (token as JValue).Value;
            else if (token is JProperty)
                return jTokenToItemValue((token as JProperty).Value);
            else if (token is JObject)
            {
                ItemValue item = new ItemValue();
                foreach (JProperty jp in (token as JObject).Properties())
                {
                    object o = jTokenToItemValue(jp.Value);
                    if (o is ItemValue)
                    {
                        ItemValue iv = o as ItemValue;
                        iv.name = jp.Name;
                        item.AddItem(iv);
                    }
                    else
                        item.AddItem(jp.Name, o);
                }
                return item;
            }
            else if (token is JArray)
            {
                ItemValue item = new ItemValue();
                foreach (JToken t in (token as JArray))
                {
                    object o = jTokenToItemValue(t);
                    if (o is ItemValue)
                        item.AddItem(o as ItemValue);
                    else
                        item.AddItem("", o);
                }
                return item;
            }
            return "";
        }


        static string[] ignoreList = "objectType,parent,name,sysid,to".Split(',');
        public static JObject msgItemToJObject(itemBase item, WebReplyMode mode = WebReplyMode.All)
        {
            bool isMesCommand = item is Command;
            JObject jo = new JObject();
            if (mode == WebReplyMode.All || !isMesCommand)
            {
                jo.Add("objectType", new JValue(item.GetType().Name));
                jo.Add("name", new JValue(item.name));
                jo.Add("sysid", new JValue(item.sysid));
            }
            if (isMesCommand) return jo;
            foreach (string propName in item.propertyNames)
            {
                if (ignoreList.Contains(propName.ToLower())) continue;
                object value = item.getProperty(propName);
                if (value == null) continue;
                if (value is string || value.GetType().IsValueType)
                    jo.Add(propName, new JValue(value));
                else if (value is itemBase)
                    jo.Add(propName, msgItemToJObject(value as itemBase));
                else if (value is System.Collections.IEnumerable)
                {
                    JArray ja = new JArray();
                    foreach (object o in value as System.Collections.IEnumerable)
                    {
                        if (o is itemBase)
                            ja.Add(msgItemToJObject(o as itemBase));
                        else if (o is string || o.GetType().IsValueType)
                            ja.Add(new JValue(o));
                        else//不是itemBase就不用再跑迴圈了
                            break;
                    }
                    if (ja.Count > 0)
                        jo.Add(propName, ja);
                }
            }
            return jo;
        }
        public static string MesMessageToJson(messageBase msg, WebReplyMode mode = WebReplyMode.All)
        {
            try
            {
                msg.setCallByMessage(true);
                if (msg is notifyCollection)
                {
                    JArray ja = new JArray();
                    notifyCollection nc = msg as notifyCollection;
                    foreach (messageBase mb in nc.Items)
                    {
                        JObject jo = msgItemToJObject(mb, mode);

                        if (mode == WebReplyMode.All)
                            jo.Add("to", new JValue(mb.To));

                        if (mb is Command)
                            MesCommandToJson(jo, mb as Command, mode);
                        ja.Add(jo);
                    }
                    return ja.ToString();
                }
                else
                {
                    JObject jo = msgItemToJObject(msg, mode);

                    if (mode == WebReplyMode.All)
                        jo.Add("to", new JValue(msg.To));

                    if (msg is Command)
                        MesCommandToJson(jo, msg as Command, mode);

                    return jo.ToString();
                }
            }
            finally
            {
                msg.setCallByMessage(false);
            }
            //StringBuilder sb = new StringBuilder(jo.ToString());
            //sb.Replace("\r\n", "");
            //return sb.ToString();
        }
        static void MesCommandToJson(JObject jo, Command cmd, WebReplyMode mode = WebReplyMode.All)
        {
            if (mode == WebReplyMode.All)
            {
                jo.Add("assemblyName", new JValue(cmd.AssemblyName));
                jo.Add("className", new JValue(cmd.ClassName));
                jo.Add("sender", new JValue(cmd.Sender));
                jo.Add("txnActor", new JValue((int)cmd.txnActor));
            }

            jo.Add("result", new JValue(cmd.result));
            jo.Add("errMessage", new JValue(cmd.errMessage));

            if (cmd.ArgumentCount > 0 && mode != WebReplyMode.Simple)
            {
                JObject joItem = new JObject();
                jo.Add("arguments", joItem);
                foreach (ItemValue item in cmd.Arguments)
                    joItem.Add(item.name, itemValueToJtoken(item));
            }

            if (cmd.Count > 0)
            {
                if (cmd.Item(0).name == null || cmd.Item(0).name.Equals(""))
                {
                    JArray jaItem = new JArray();
                    jo.Add("items", jaItem);
                    foreach (ItemValue item in cmd.Items)
                        jaItem.Add(itemValueToJtoken(item));
                }
                else
                {
                    if (mode == WebReplyMode.Simple)
                    {
                        foreach (ItemValue item in cmd.Items)
                            jo.Add(item.name, itemValueToJtoken(item));
                    }
                    else
                    {
                        JObject joItem = new JObject();
                        jo.Add("items", joItem);
                        foreach (ItemValue item in cmd.Items)
                            joItem.Add(item.name, itemValueToJtoken(item));
                    }
                }
            }
        }
        public static JToken itemValueToJtoken(ItemValue item)
        {
            if (item.Count == 0)
            {
                if (item.Value is itemBase)
                    return msgItemToJObject(item.Value as itemBase);
                else
                    return new JValue(item.Value);
            }
            else
            {
                if (item.Item(0).name == null || item.Item(0).name.Equals(""))
                {
                    JArray ja = new JArray();
                    foreach (ItemValue sub in item.Items)
                        ja.Add(itemValueToJtoken(sub));
                    return ja;
                }
                else
                {
                    JObject jo = new JObject();
                    foreach (ItemValue sub in item.Items)
                        jo.Add(sub.name, itemValueToJtoken(sub));
                    return jo;
                }
            }
        }

        static void logError(Exception ex, string json)
        {
            try
            {
                NLog.Logger logger = NLog.LogManager.GetLogger("errLogger");
                string errMsg = "JsonToMesCommand Error, ClientIP=" + Instance.requestClientAdress() + Environment.NewLine + "ErrMsg=" + ex.Message + Environment.NewLine + "JSON=" + json;
                Console.WriteLine(errMsg);
                if (logger != null)
                    logger.Error(errMsg);
            }
            catch { }
        }
    }

    public class WebServiceClientAgent
    {
        static System.Collections.Concurrent.ConcurrentDictionary<string, Type> dicTypes = new System.Collections.Concurrent.ConcurrentDictionary<string, Type>();
        public static object InvokeWebService(string url, string methodName, object[] args)
        {
            return InvokeWebService("Default", url, methodName, args);
        }
        public static object InvokeWebService(string nameSpace, string url, string methodName, object[] args)
        {
            if (!dicTypes.ContainsKey(url))
            {
                //获取WSDL
                WebClient wc = new WebClient();
                Stream stream = wc.OpenRead(url + "?WSDL");
                ServiceDescription sd = ServiceDescription.Read(stream);
                string classname = sd.Services[0].Name;
                ServiceDescriptionImporter sdi = new ServiceDescriptionImporter();
                sdi.AddServiceDescription(sd, "", "");
                CodeNamespace cn = new CodeNamespace(nameSpace);

                //生成客户端代理类代码
                CodeCompileUnit ccu = new CodeCompileUnit();
                ccu.Namespaces.Add(cn);
                sdi.Import(cn, ccu);

                //设定编译参数
                CompilerParameters cplist = new CompilerParameters();
                cplist.GenerateExecutable = false;
                cplist.GenerateInMemory = true;
                cplist.ReferencedAssemblies.Add("System.dll");
                cplist.ReferencedAssemblies.Add("System.XML.dll");
                cplist.ReferencedAssemblies.Add("System.Web.Services.dll");
                cplist.ReferencedAssemblies.Add("System.Data.dll");

                //编译代理类

                //CSharpCodeProvider csc = new CSharpCodeProvider();
                //ICodeCompiler icc = csc.CreateCompiler();
                //CompilerResults cr = icc.CompileAssemblyFromDom(cplist, ccu);
                CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
                CompilerResults cr = provider.CompileAssemblyFromDom(cplist, ccu);
                if (true == cr.Errors.HasErrors)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    foreach (System.CodeDom.Compiler.CompilerError ce in cr.Errors)
                    {
                        sb.Append(ce.ToString());
                        sb.Append(System.Environment.NewLine);
                    }
                    throw new Exception(sb.ToString());
                }

                //生成代理实例，并调用方法
                System.Reflection.Assembly assembly = cr.CompiledAssembly;
                dicTypes[url] = assembly.GetType(nameSpace + "." + classname, true, true);
            }
            Type t = dicTypes[url];
            object obj = Activator.CreateInstance(t);
            System.Reflection.MethodInfo mi = t.GetMethod(methodName);

            return mi.Invoke(obj, args);
        }
    }
}
