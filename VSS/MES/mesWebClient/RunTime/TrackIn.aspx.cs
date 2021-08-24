using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mesWebClient.RunTime
{
    public partial class TrackIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            if (!IsPostBack)
            {
                mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot(Request["lotId"]);
                ShowLotInfo(lot);
                ShowWorkingInstruction(lot);
                ShowEquipment(lot);
                prevEqpId.Value = Request["eqpId"];
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Global.SwitchLanguage(this);
            base.Render(writer);
        }

        void ShowLotInfo(mesRelease.WIP.Lot lot)
        {
            txtLotId.Text = lot.name;
            txtStatus.Text = lot.status;
            txtQuantity.Text = lot.quantity.ToString();
            txtUnit.Text = lot.unit;
            txtLotType.Text = lot.lotType;
            txtProduct.Text = lot.productId;
            txtOrder.Text = lot.orderId;
            txtFab.Text = lot.fab;
            txtStep.Text = lot.stepId;
        }
        void ShowWorkingInstruction(mesRelease.WIP.Lot lot)
        {
            foreach (mesRelease.WIP.WorkingInstruction wi in mesRelease.WIP.WorkingInstruction.GetWorkingInstruction(lot))
            {
                txtWorkingInstruction.Text += wi.instruction + Environment.NewLine;
            }
        }
        void ShowEquipment(mesRelease.WIP.Lot lot)
        {
            SortedList<string, mesRelease.EQP.Equipment> srtList = new SortedList<string, mesRelease.EQP.Equipment>();
            foreach (mesRelease.EQP.Equipment eq in mesRelease.EQP.Equipment.GetEquipmentsByStep(lot.fab, "", lot.stepId))
                srtList.Add(eq.name, eq);
            gridEquipments.DataSource = srtList.Values;
            gridEquipments.DataBind();
            
        }

        protected void buttonOK_Click(object sender, EventArgs e)
        {
            if (gridEquipments.SelectedRow == null) return;
            mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot(txtLotId.Text);
            mesRelease.WIP.Txn.TrackIn txn = new mesRelease.WIP.Txn.TrackIn();
            txn.Add(lot);
            txn.txnUser = "don";
            txn.comments = txtComments.Text;
            txn.equipmentId = gridEquipments.SelectedRow.Cells[1].Text;
            txn = txn.doTxn();
            if (txn.result.Equals("PASS"))
            {
                mesRelease.WF.WorkFlow.DispatchToNext(lot, "PASS");
                Response.Redirect("../StepTxn.aspx?Fab=" + txtFab.Text + "&Step=" + txtStep.Text + "&Equipment=" + prevEqpId.Value, true);
            }
            else
            {
                lblInfo.Text = txn.errMessage;
                lblInfo.Visible = true;
            }
        }
    }
}