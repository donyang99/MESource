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
    public partial class frmLotProperty : mesClientInterface.mesDockContent
    {
        public frmLotProperty()
        {
            InitializeComponent();
            lotInfomation1.Init();
        }
        public override void MESItemSelectionChange(idv.messageService.itemBase item, Type type)
        {
            if (type.Equals(typeof(mesRelease.WIP.Lot)))
                lotInfomation1.Init(item as mesRelease.WIP.Lot);
        }
        public override void userLogin()
        {
            
        }
        public override void userLogout()
        {
            
        }
    }
}
