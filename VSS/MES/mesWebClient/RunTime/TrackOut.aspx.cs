using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mesWebClient.RunTime
{
    public partial class TrackOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            if (!IsPostBack)
            {
                mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot(Request["lotId"]);
                ShowLotInfo(lot);
                ShowStepDC(lot);
                prevEqpId.Value = Request["eqpId"];
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Global.SwitchLanguage(this);
            StepDC.Visible = gridStepDC.Rows.Count > 0;
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

        void ShowStepDC(mesRelease.WIP.Lot lot)
        {
            mesRelease.PRP.Step step = lot.GetCurrentStep();
            gridStepDC.DataSource = step.DCItemsGet();
            gridStepDC.DataBind();
        }

        protected void buttonOK_Click(object sender, EventArgs e)
        {
            List<mesRelease.PRP.DCItem> list = new List<mesRelease.PRP.DCItem>();
            foreach (GridViewRow row in gridStepDC.Rows)
            {
                Label dcName = row.FindControl("lblName") as Label;
                TextBox dcValue = row.FindControl("value") as TextBox;
                if (dcValue.Text.Trim().Equals(""))
                {
                    lblInfo.Text = "資料收集項目【" + dcName.Text + "】未輸入資料";
                    lblInfo.Visible = true;
                    return;
                }
                mesRelease.PRP.DCItem dcItem = mesRelease.PRP.DCItem.getDCItem(dcName.Text);
                dcItem.itemValue = dcValue.Text;
                list.Add(dcItem);
            }

            mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot(txtLotId.Text);
            mesRelease.WIP.Txn.TrackOut txn = new mesRelease.WIP.Txn.TrackOut();
            txn.Add(lot);
            txn.txnUser = "don";
            txn.comments = txtComments.Text;
            txn.dcItemList.AddRange(list);
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