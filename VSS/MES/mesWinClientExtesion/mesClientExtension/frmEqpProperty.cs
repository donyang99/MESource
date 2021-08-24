using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesWinClient.Ext
{
    public partial class frmEqpProperty : mesClientInterface.mesDockContent
    {
        public frmEqpProperty()
        {
            InitializeComponent();
            equipmentInformation1.Init();
        }
        public override void MESItemSelectionChange(idv.messageService.itemBase item, Type type)
        {
            if (type.Equals(typeof(mesRelease.EQP.Equipment)))
                equipmentInformation1.Init(item as mesRelease.EQP.Equipment);
        }
        public override void userLogin()
        {

        }
        public override void userLogout()
        {

        }
    }
}
