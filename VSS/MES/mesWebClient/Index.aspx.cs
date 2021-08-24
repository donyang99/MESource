using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using idv.utilities;

namespace mesWebClient
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cboFab.Items.Add("");
                foreach (string s in mesRelease.BAS.Fab.GetFabNames())
                    cboFab.Items.Add(s);
                
                foreach (string s in idv.utilities.cultureLanguage.availableLanguage)
                {
                    ListItem item = new ListItem();
                    item.Value = s;
                    item.Text = Global.GetLanguageValue(s);
                    if (s.Equals("zh-TW")) item.Selected = true;
                    cboLanguage.Items.Add(item);
                }
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Global.SwitchLanguage(this);
            base.Render(writer);
        }

        protected void cboFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStep.Items.Clear();
            if (cboFab.Text.Equals("")) return;
            cboStep.Items.Add("");

            SortedList<string, mesRelease.PRP.Step> srtList = new SortedList<string, mesRelease.PRP.Step>();
            foreach (mesRelease.PRP.Step s in mesRelease.PRP.Step.GetActiveVersionSteps(""))
                srtList.Add(s.name, s);

            foreach (mesRelease.PRP.Step s in srtList.Values)
            {
                if (s.fab.Equals("ALL") || s.fab.Equals(cboFab.Text))
                    cboStep.Items.Add(s.name);
            }
        }

        protected void cboStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEquipment.Items.Clear();
            if (cboStep.Text.Equals("") || cboFab.Text.Equals("")) return;
            cboEquipment.Items.Add("");

            SortedList<string, mesRelease.EQP.Equipment> srtList = new SortedList<string, mesRelease.EQP.Equipment>();
            foreach(mesRelease.EQP.Equipment eq in mesRelease.EQP.Equipment.GetEquipmentsByStep(cboFab.Text, "", cboStep.Text))
                srtList.Add(eq.name,eq);

            foreach (mesRelease.EQP.Equipment eq in srtList.Values)
                cboEquipment.Items.Add(eq.name);
            
        }

        protected void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem item = cboLanguage.SelectedItem;
            Global.SetLanguage(item.Value);
        }

        protected void buttonOK_Click(object sender, EventArgs e)
        {
            if (cboFab.Text.Equals("") || cboStep.Text.Equals("") || cboEquipment.Text.Equals("")) return;
            Response.Redirect("StepTxn.aspx?Fab=" + cboFab.Text + "&Step=" + cboStep.Text + "&Equipment=" + cboEquipment.Text, true);
        }


    }
}