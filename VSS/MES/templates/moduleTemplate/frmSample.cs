using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace moduleTemplate
{
    public partial class frmSample : Form
    {
        public frmSample()
        {
            InitializeComponent();
            actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(actionToolbar1_ActionClicked);
            initToolbar();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Query"].Visible = false;//hide button if button is not needed
            actionToolbar1.addButton("Export", "Export");//add button needed with privilege string
            actionToolbar1.addButton("Exit", "");//add button needed without privilege control
        }

        void actionToolbar1_ActionClicked(string actionName)
        {
            switch (actionName)
            { 
                case "Add":
                    idv.utilities.messageBox.showMessage("Add");
                    break;
                case "Modify":
                    idv.utilities.messageBox.showMessageById("Modify");
                    break;
            }
        }
    }
}
