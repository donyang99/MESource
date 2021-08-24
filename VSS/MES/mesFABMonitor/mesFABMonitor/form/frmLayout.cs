using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.messageService;
using mesRelease.USR;
using idv.utilities;

namespace mesFABMonitor
{
    public partial class frmLayout : Form
    {
        List<moveableRuntime> mrList = new List<moveableRuntime>();
        moveableRuntime mr = null;
        public frmLayout()
        {
            InitializeComponent();
            mr = new moveableRuntime(pnlFAB);
            getAreas();
            List<mesRelease.EQP.Equipment> list = new List<mesRelease.EQP.Equipment>();
            list.AddRange(mesRelease.EQP.Equipment.GetEquipments(false, true));
            list.AddRange(mesRelease.EQP.Equipment.GetEquipments(true, true));
            lvwEquipment.prepareColumns();
            lvwEquipment.ShowMESItems(list.ToArray());
            mnuAdd.Enabled = User.loginUser.CheckFunctionPrivilege("IDE:FMS:AREA:ADD");
            mnuDelete.Enabled = User.loginUser.CheckFunctionPrivilege("IDE:FMS:AREA:DELETE");
            splitContainer3.SplitterDistance = 24;
            splitContainer3.SplitterWidth = 1;            
        }

        private void control_Click(object sender, EventArgs e)
        {
            mr.SelectControl(sender);            
        }

        private void getAreas()
        {
            lvwArea.Items.Clear();
            IMessageGuard conn = serviceHost.Client;
            try
            {
                DataSet ds = conn.getDataSet("select * from fms_area where delete_flag = '0'");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ListViewItem li = new ListViewItem();
                    li.Name = dr["area_id"].ToString();
                    li.Text = li.Name;
                    li.SubItems.Add(dr["description"].ToString());
                    li.SubItems.Add(dr["image_file"].ToString());
                    li.Tag = dr["sysid"].ToString();
                    lvwArea.Items.Add(li);
                }
            }
            catch { }
        }

        private string setBackgroundMap(string fileName)
        {
            Image img=null;
            if (fileName != null || fileName != "")
            { }
            else
            {

            }
            try { img = Image.FromFile(".\\img\\" + fileName); }
            catch { }
            pnlFAB.BackgroundImage = img;
            if (img != null)
            {
                pnlFAB.MinimumSize = img.Size;             
            }
            else
            {
                pnlFAB.MinimumSize = new Size(500, 500);
            }
            return fileName;
        }

        private void lvwArea_DoubleClick(object sender, EventArgs e)
        {            
            ListView lv = sender as ListView;
            ListViewItem li = lv.SelectedItems[0];
            if (li == null)
                txtCurrentArea.Text = "";
            else
            {
                if (txtCurrentArea.Text == li.Text) return;
                pnlFAB.Hide();
                mr.SelectControl(null);
                pnlFAB.Controls.Clear();                
                txtCurrentArea.Text = li.Text;
                setBackgroundMap(li.SubItems[2].Text);
                loadEquipments();
                pnlFAB.Show();
            }
        }

        public void loadEquipments()
        {
            IMessageGuard conn = serviceHost.Client;
            string sql = "select a.area_id,b.equipment_sysid,b.pos_x,b.pos_y,b.width,b.height,b.graph_type " +
                         "from fms_area a join fms_area_equipment b on a.sysid=b.area_sysid " +
                         "where a.area_id='" + txtCurrentArea.Text + "'";
            try
            {
                DataSet ds = conn.getDataSet(sql);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cLabel c = new cLabel();
                    c.Name = getEqName(dr["equipment_sysid"].ToString());
                    try
                    {
                        c.Location = new Point(int.Parse(dr["pos_x"].ToString()), int.Parse(dr["pos_y"].ToString()));
                    }
                    catch { }
                    try
                    {
                        c.Size = new Size(int.Parse(dr["width"].ToString()), int.Parse(dr["height"].ToString()));
                    }
                    catch { }
                    c.Text = c.Name;
                    c.BackColor = SystemColors.ButtonFace;
                    c.TextAlign = ContentAlignment.MiddleCenter;
                    c.Click += new EventHandler(cLabel_Click);
                    pnlFAB.Controls.Add(c);
                }
            }
            catch { }
        }

        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {
            pnlFAB.Size = new Size(splitContainer1.Panel2.Size.Width - 4, splitContainer1.Panel2.Size.Height - 4);
        }

        private void lvwEquipment_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && txtCurrentArea.Text != "")
            {
                ListViewItem li = lvwEquipment.GetItemAt(e.X, e.Y);
                if (li == null) return;
                lvwEquipment.DoDragDrop(li, DragDropEffects.All);
            }
        }

        private void pnlFAB_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;          
        }

        private void pnlFAB_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem li = e.Data.GetData(e.Data.GetFormats()[0]) as ListViewItem;
            if (li == null) return;
            cLabel newEq = addEqToFAB(li.Text);

            if (newEq != null)
            {
                newEq.Location = pnlFAB.PointToClient(new Point(e.X - newEq.Width / 2, e.Y - newEq.Height / 2));
                mr.SelectControl(newEq);
            }  
        }

        private cLabel addEqToFAB(string equipmentId)
        {
            cLabel c = pnlFAB.Controls[equipmentId] as cLabel;
            if (c != null)
            {
                mr.SelectControl(c);
                return null;
            }
            else 
            {
                c = new cLabel();
                pnlFAB.Controls.Add(c);
                c.BackColor = SystemColors.ButtonFace;
                c.Name = equipmentId;
                c.Text = equipmentId;
                c.TextAlign = ContentAlignment.MiddleCenter;
                c.Click += new EventHandler(cLabel_Click);                
            }
            return c;
        }

        void cLabel_Click(object sender, EventArgs e)
        {
            splitContainer1.ActiveControl = null; // for form KeyPreview frmLayout_KeyDown
            if (ModifierKeys == Keys.Control && mr.SelectedControl != null)
            {
                for (int i = 0; i < mrList.Count; i++)
                {
                    moveableRuntime m = mrList[i];
                    if (m.SelectedControl == sender)
                    {
                        if (m == mr)
                        {
                            if (i < (mrList.Count - 1))
                                mr = mrList[i + 1];
                            else if (i > 0)
                                mr = mrList[i - 1];
                            if (!mr.IsActive)
                                mr.IsActive = true;
                        }
                        m.SelectControl(null);
                        m.Clear();
                        mrList.Remove(m);
                        return;
                    }
                }
                mr.IsActive = false;
                if (!mrList.Contains(mr))
                    mrList.Add(mr);
                mr = new moveableRuntime(pnlFAB);
                mrList.Add(mr);
                mr.SelectControl(sender);
                if (!mr.IsActive)
                    mr.IsActive = true;
            }
            else
            {
                bool found = false;
                for (int i = 0; i < mrList.Count; i++)
                {
                    moveableRuntime m = mrList[i];
                    if (m.SelectedControl == sender)
                    {
                        if (!m.IsActive)
                            m.IsActive = true;
                        mr = m;
                        found = true;
                    }
                    else
                    {
                        if (m.IsActive)
                            m.IsActive = false;
                    }
                }
                if (!found)
                {
                    pnlFAB_Click(null, null);
                    mr.SelectControl(sender);
                    if (!mr.IsActive)
                        mr.IsActive = true;
                }
            }
        }

        private void pnlFAB_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control) return;
            if (sender != null)
                splitContainer1.ActiveControl = splitContainer3;
            if (mrList.Count > 1)
                pnlFAB.Hide();
            foreach (moveableRuntime m in mrList)
            {
                if (m == mr) continue;
                m.SelectControl(null);
                m.Clear();
            }
            mrList.Clear();
            mr.SelectControl(null);

            pnlFAB.Show();
        }

        private void debugPrint(string s)
        {
            System.Diagnostics.Debug.Print(s);
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            frmAddArea frm = new frmAddArea();
            try
            {
                idv.utilities.cultureLanguage.switchLanguage(frm);
                frm.ShowDialog();
                if (frm.result)
                {
                    idv.messageService.sql.sqlTable table = new idv.messageService.sql.sqlTable("fms_area", idv.messageService.sql.eDMLtype.Insert);
                    string sysid = System.Guid.NewGuid().ToString();
                    table.Add("sysid", sysid);
                    table.Add("area_id", frm.area);
                    table.Add("description", frm.description);
                    table.Add("image_file", frm.backgroundPhoto);
                    table.Add("create_user", User.loginUser.name);
                    table.Add("create_date", DateTime.Now);
                    table.Add("modify_user", User.loginUser.name);
                    table.Add("modify_date", DateTime.Now);
                    idv.messageService.sql.sqlExecuter.executeSqlTable(table, idv.messageService.serviceHost.Client);
                    ListViewItem li = new ListViewItem();
                    li.Name = frm.area;
                    li.Text = li.Name;
                    li.SubItems.Add(frm.description);
                    li.SubItems.Add(frm.backgroundPhoto);
                    li.Tag = sysid;
                    lvwArea.Items.Add(li);
                }
            }
            catch { }
            finally
            {
                frm.Close();
            }
        }
        private void mnuModify_Click(object sender, EventArgs e)
        {
            if (lvwArea.SelectedItems.Count == 0) return;
            bool editCurrentArea = false;
            frmAddArea frm = new frmAddArea();
            try
            {
                ListViewItem li = lvwArea.SelectedItems[0];
                if (txtCurrentArea.Text == li.Name) editCurrentArea = true;
                frm.area = li.Name;
                frm.description = li.SubItems[1].Text;
                frm.backgroundPhoto = li.SubItems[2].Text;
                idv.utilities.cultureLanguage.switchLanguage(frm);
                frm.ShowDialog();
                if (frm.result)
                {
                    idv.messageService.sql.sqlTable table = new idv.messageService.sql.sqlTable("fms_area", idv.messageService.sql.eDMLtype.Update);
                    string sysid = li.Tag.ToString();
                    table.WhereClause.Add("sysid", sysid);
                    table.Add("area_id", frm.area);
                    table.Add("description", frm.description);
                    table.Add("image_file", frm.backgroundPhoto);
                    table.Add("modify_user", User.loginUser.name);
                    table.Add("modify_date", DateTime.Now);
                    idv.messageService.sql.sqlExecuter.executeSqlTable(table, idv.messageService.serviceHost.Client);
                    li.Name = frm.area;
                    li.Text = li.Name;
                    li.SubItems[1].Text = frm.description;
                    li.SubItems[2].Text = frm.backgroundPhoto;
                    if (editCurrentArea)
                    {
                        txtCurrentArea.Text = frm.area;
                        setBackgroundMap(frm.backgroundPhoto);
                    }
                }
            }
            catch { }
            finally
            {
                frm.Close();
            }
        }
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (lvwArea.SelectedItems.Count == 0) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                idv.messageService.sql.sqlTable table = new idv.messageService.sql.sqlTable("fms_area", idv.messageService.sql.eDMLtype.Delete);
                table.WhereClause.Add("sysid", lvwArea.SelectedItems[0].Tag.ToString());
                idv.messageService.sql.sqlExecuter.executeSqlTable(table, idv.messageService.serviceHost.Client);
                table = new idv.messageService.sql.sqlTable("fms_area_equipment", idv.messageService.sql.eDMLtype.Delete);
                table.WhereClause.Add("area_sysid", lvwArea.SelectedItems[0].Tag.ToString());
                idv.messageService.sql.sqlExecuter.executeSqlTable(table, idv.messageService.serviceHost.Client);

                if (lvwArea.SelectedItems[0].Text == txtCurrentArea.Text)
                {
                    txtCurrentArea.Text = "";
                    setBackgroundMap(null);
                    pnlFAB.Controls.Clear();
                }
                lvwArea.Items.Remove(lvwArea.SelectedItems[0]);
            }
            catch { }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "btnSave":
                    Save();
                    break;
                case "btnDelete":
                    if (mrList.Count > 1)
                        pnlFAB.Hide();
                    foreach (moveableRuntime m in mrList)
                    {
                        if (m == mr) continue;
                        if (m.SelectedControl != null)
                            pnlFAB.Controls.Remove(m.SelectedControl);
                        m.SelectControl(null);
                        m.Clear();
                    }
                    mrList.Clear();
                    
                    if (mr.SelectedControl != null)
                    {
                        pnlFAB.Controls.Remove(mr.SelectedControl);
                        mr.SelectControl(null);
                    }
                    pnlFAB.Show();
                    break;
            }
        }

        void Save()
        {
            if (txtCurrentArea.Text == "") return;
            ListViewItem li = lvwArea.Items[txtCurrentArea.Text];
            if (li == null) return;
            IMessageGuard mg = null;
            List<idv.messageService.sql.sqlTable> list = new List<idv.messageService.sql.sqlTable>();
            try
            {
                idv.messageService.sql.sqlTable table = new idv.messageService.sql.sqlTable("fms_area_equipment", idv.messageService.sql.eDMLtype.Delete);
                string areaSysId = li.Tag.ToString();
                table.WhereClause.Add("area_sysid", areaSysId);
                list.Add(table);
                foreach (Control ctrl in pnlFAB.Controls)
                {
                    if (!(ctrl is cLabel)) continue;
                    table = new idv.messageService.sql.sqlTable("fms_area_equipment", idv.messageService.sql.eDMLtype.Insert);
                    table.Add("area_sysid", areaSysId);
                    table.Add("equipment_sysid", getEqSysId(ctrl.Name));
                    table.Add("pos_x", ctrl.Left);
                    table.Add("pos_y", ctrl.Top);
                    table.Add("width", ctrl.Width);
                    table.Add("height", ctrl.Height);
                    list.Add(table);
                }
                mg = idv.messageService.serviceHost.Client;
                mg.beginTxn();
                idv.messageService.sql.sqlExecuter.executeSqlTables(list, mg);
                mg.commitTxn();
                idv.utilities.messageBox.showMessageById("msgExecuteSucceed", messageStyle.confirmation);
            }
            catch (Exception ex)
            {
                if (mg != null)
                    mg.rollbackTxn();
                idv.utilities.messageBox.showMessage(ex.Message);
            }
        }
        string getEqSysId(string equipmentId)
        {
            foreach (idv.messageService.itemBase item in lvwEquipment.GetAllMESItem())
            {
                if (item.name == equipmentId)
                    return item.sysid;
            }
            return "";
        }
        string getEqName(string sysId)
        {
            foreach (idv.messageService.itemBase item in lvwEquipment.GetAllMESItem())
            {
                if (item.sysid == sysId)
                    return item.name;
            }
            return "";
        }

        private void mnuSameHeight_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;            
            foreach (moveableRuntime m in mrList)
            {
                if (m == mr) continue;
                Size sz = m.SelectedControl.Size;
                sz.Height = mr.SelectedControl.Size.Height;
                m.SelectedControl.Size = sz;
                m.SelectControl(m.SelectedControl);
            }
        }

        private void mnuSameWidth_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;
            foreach (moveableRuntime m in mrList)
            {
                if (m == mr) continue;
                Size sz = m.SelectedControl.Size;
                sz.Width = mr.SelectedControl.Size.Width;
                m.SelectedControl.Size = sz;
                m.SelectControl(m.SelectedControl);
            }
        }

        private void mnuSameAll_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;
            foreach (moveableRuntime m in mrList)
            {
                if (m == mr) continue;
                m.SelectedControl.Size = mr.SelectedControl.Size;
                m.SelectControl(m.SelectedControl);
            }
        }

        private void mnuAlignTop_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;
            foreach (moveableRuntime m in mrList)
            {
                if (m == mr) continue;
                (m.SelectedControl as cLabel).preTop = m.SelectedControl.Top;
                (m.SelectedControl as cLabel).preLeft = 0; 
                m.SelectedControl.Top = mr.SelectedControl.Top;
                m.SelectControl(m.SelectedControl);
            }
        }

        private void mnuAlignBottom_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;
            foreach (moveableRuntime m in mrList)
            {
                if (m == mr) continue;
                (m.SelectedControl as cLabel).preTop = m.SelectedControl.Top;
                (m.SelectedControl as cLabel).preLeft = 0; 
                m.SelectedControl.Top = mr.SelectedControl.Top + mr.SelectedControl.Height - m.SelectedControl.Height;
                m.SelectControl(m.SelectedControl);
            }
        }

        private void mnuAlignLeft_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;
            foreach (moveableRuntime m in mrList)
            {
                if (m == mr) continue;
                (m.SelectedControl as cLabel).preTop = 0;
                (m.SelectedControl as cLabel).preLeft = m.SelectedControl.Left; 
                m.SelectedControl.Left = mr.SelectedControl.Left;
                m.SelectControl(m.SelectedControl);
            }
        }

        private void mnuAlignRight_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;
            foreach (moveableRuntime m in mrList)
            {
                if (m == mr) continue;
                (m.SelectedControl as cLabel).preTop = 0;
                (m.SelectedControl as cLabel).preLeft = m.SelectedControl.Left;
                m.SelectedControl.Left = mr.SelectedControl.Left + mr.SelectedControl.Width - m.SelectedControl.Width;
                m.SelectControl(m.SelectedControl);
            }
        }

        private void mnuConcatH_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;
            SortedList<int, Control> list = new SortedList<int, Control>();
            foreach (moveableRuntime m in mrList)
            {
                while (list.ContainsKey(m.SelectedControl.Left))
                {
                    m.SelectedControl.Left++;
                }
                list.Add(m.SelectedControl.Left, m.SelectedControl);
            }

            int i = 0;
            foreach (Control ctrl in list.Values)
            {
                if (i == 0)
                {
                    i = ctrl.Left + ctrl.Width;
                    (ctrl as cLabel).preTop = 0;
                    (ctrl as cLabel).preLeft = 0;
                }
                else
                {
                    (ctrl as cLabel).preTop = 0;
                    (ctrl as cLabel).preLeft = ctrl.Left;
                    ctrl.Left = i + 1;
                    i = ctrl.Left + ctrl.Width;
                }
            }

            foreach (moveableRuntime m in mrList)
                m.SelectControl(m.SelectedControl);

        }

        private void mnuConcatV_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;
            SortedList<int, Control> list = new SortedList<int, Control>();
            foreach (moveableRuntime m in mrList)
            {
                while (list.ContainsKey(m.SelectedControl.Top))
                {
                    m.SelectedControl.Top++;
                }
                list.Add(m.SelectedControl.Top, m.SelectedControl);
            }

            int i = 0;
            foreach (Control ctrl in list.Values)
            {
                if (i == 0)
                {
                    i = ctrl.Top + ctrl.Height;
                    (ctrl as cLabel).preTop = 0;
                    (ctrl as cLabel).preLeft = 0;
                }
                else
                {
                    (ctrl as cLabel).preTop = ctrl.Top;
                    (ctrl as cLabel).preLeft = 0;
                    ctrl.Top = i + 1;
                    i = ctrl.Top + ctrl.Height;
                }
            }

            foreach (moveableRuntime m in mrList)
                m.SelectControl(m.SelectedControl);
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if (mrList.Count <= 1) return;
            foreach (moveableRuntime m in mrList)
            {
                (m.SelectedControl as cLabel).UndoLocation();
                m.SelectControl(m.SelectedControl);
            }
        }

        private void frmLayout_KeyDown(object sender, KeyEventArgs e)
        {
            if (splitContainer1.ActiveControl != null) return;
            e.Handled = true;
            if (mrList.Count == 0)
                mr.PreviewKeyDown(e.KeyCode, e.Shift);
            else
            {
                foreach (moveableRuntime m in mrList)
                    m.PreviewKeyDown(e.KeyCode, e.Shift);
            }
        }
    }
}
