using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mesWebClient.RunTime
{
    public partial class MoveOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            if (!IsPostBack)
            {
                mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot(Request["lotId"]);
                ShowLotInfo(lot);
                ShowPaths(lot);
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
            txtEqpId.Text = lot.equipmentId;
        }
        void ShowPaths(mesRelease.WIP.Lot lot)
        {
            cboPath.Items.Clear();
            cboPath.Items.Add("");
            foreach (string path in lot.GetCurrentStep().availablePaths)
                cboPath.Items.Add(path);

            if (cboPath.Items.Count == 2)
            {
                cboPath.Items[1].Selected = true;
                cboPath_SelectedIndexChanged(cboPath, null);
            }

            if (cboPath.Items.Count <= 2)
                cboPath.Enabled = false;
        }

        protected void cboPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPath.Text.Equals("")) return;
            mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot(txtLotId.Text);
            mesRelease.PRP.Route route = lot.GetRoute();
            mesRelease.PRP.Step nextStep = route.NextStep(lot.GetCurrentStep().stepHandle, cboPath.Text);
            txtNextStep.Text = nextStep.name;
            txtNextWI.Text="";
            foreach (mesRelease.WIP.WorkingInstruction wi in mesRelease.WIP.WorkingInstruction.GetWorkingInstruction(lot, nextStep.name))
                txtNextWI.Text += wi.instruction + Environment.NewLine;
        }

        protected void buttonOK_Click(object sender, EventArgs e)
        {
            if (cboPath.Items.Count > 1 && cboPath.Text.Equals("")) return;
            string path = "PASS";
            if (!cboPath.Equals(""))
                path = cboPath.Text;

            mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot(txtLotId.Text);
            mesRelease.WIP.Txn.MoveOut txn = new mesRelease.WIP.Txn.MoveOut();
            txn.Add(lot);
            txn.txnUser = "don";
            txn.comments = txtComments.Text;
            txn.result = path;
            txn = txn.doTxn();
            if (txn.result.Equals("PASS"))
            {
                mesRelease.WF.WorkFlow.DispatchToNext(lot, path);
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