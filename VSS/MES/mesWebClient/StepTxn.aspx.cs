using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mesWebClient
{
    public partial class StepTxn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtFab.Text = Request["Fab"];
                txtStep.Text = Request["Step"];
                txtEquipment.Text = Request["Equipment"];
            }

            SortedList<string, mesRelease.WIP.Lot> srtList = new SortedList<string, mesRelease.WIP.Lot>();
            foreach (mesRelease.WIP.Lot lot in mesRelease.WIP.Lot.GetLotsByEquipment(txtFab.Text, txtEquipment.Text, false, true))
                srtList.Add(lot.name, lot);
            gridWaitForTrackIn.DataSource = srtList.Values;
            gridWaitForTrackIn.DataBind();

            srtList = new SortedList<string, mesRelease.WIP.Lot>();
            foreach (mesRelease.WIP.Lot lot in mesRelease.WIP.Lot.GetLotsByEquipment(txtFab.Text, txtEquipment.Text, true, false))
                srtList.Add(lot.name, lot);
            gridWaitForTrackOut.DataSource = srtList.Values;
            gridWaitForTrackOut.DataBind();

            srtList = new SortedList<string, mesRelease.WIP.Lot>();
            foreach (mesRelease.WIP.Lot lot in mesRelease.WIP.Lot.GetLotsForMoveOut(txtFab.Text, txtStep.Text,txtEquipment.Text))
                srtList.Add(lot.name, lot);
            gridWaitForMoveOut.DataSource = srtList.Values;
            gridWaitForMoveOut.DataBind();
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Global.SwitchLanguage(this);
            base.Render(writer);
        }

        protected void trackIn_Click(object sender, EventArgs e)
        {
            if (gridWaitForTrackIn.SelectedRow == null) return;
            string lotId = gridWaitForTrackIn.SelectedRow.Cells[1].Text;
            Response.Redirect("RunTime/TrackIn.aspx?lotId=" + lotId + "&eqpId=" + txtEquipment.Text, true);
        }

        protected void trackOut_Click(object sender, EventArgs e)
        {
            if (gridWaitForTrackOut.SelectedRow == null) return;
            string lotId = gridWaitForTrackOut.SelectedRow.Cells[1].Text;
            Response.Redirect("RunTime/TrackOut.aspx?lotId=" + lotId + "&eqpId=" + txtEquipment.Text, true);
        }

        protected void moveOut_Click(object sender, EventArgs e)
        {
            if (gridWaitForMoveOut.SelectedRow == null) return;
            string lotId = gridWaitForMoveOut.SelectedRow.Cells[1].Text;
            Response.Redirect("RunTime/MoveOut.aspx?lotId=" + lotId + "&eqpId=" + txtEquipment.Text, true);
        }
    }
}