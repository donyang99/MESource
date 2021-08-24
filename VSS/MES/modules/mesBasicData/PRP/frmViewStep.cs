using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.utilities;
using mesRelease.PRP;
using idv.mesCore.Controls;
using idv.mesCore.PRP;

namespace mesBasicData
{
    public partial class frmViewStep : Form
    {
        Step _curStep = null;
        public frmViewStep()
        {
            InitializeComponent();
            lvwRules.prepareColumns();
            lvwStepDC.prepareColumns();
            cultureLanguage.switchLanguage(this);
        }

        public void Init(Step step)
        {
            _curStep = step;
            initData();
            if (!idv.mesCore.systemConfig.stepStage)
            {           
                lblStage.Visible = false;
                txtStage.Visible = false;               
            }
            if (!idv.mesCore.systemConfig.componentType)
            {            
                lblComponentType.Visible = false;
                txtComponentType.Visible = false;                
            }
            if (!idv.mesCore.systemConfig.stepCode)
            {               
                lblStepCode.Visible = false;
                txtStepCode.Visible = false;                
            }
        }

        void initData()
        {
            txtStep.Text = _curStep.name;
            txtVersion.Text = _curStep.version.ToString();
            txtEqGroup.Text = _curStep.equipmentGroup;
            txtFAB.Text = _curStep.fab;
            txtStage.Text = _curStep.stage;
            txtComponentType.Text = _curStep.componentType;
            txtStepCode.Text = _curStep.stepCode;
            txtDescription.Text = _curStep.description;
            lvwRules.ShowMESItems(_curStep.Items.ToArray());
            lvwStepDC.ShowMESItems(_curStep.DCItemsGet());           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
