using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesFABMonitor
{
    public class cLabel : Label
    {
        public cLabel()
        {
            //設為可以取得輸入焦點
            SetStyle(ControlStyles.Selectable, true);
        }

        int _preTop = 0;
        public int preTop
        {
            get { return _preTop; }
            set { _preTop = value; }
        }

        int _preLeft = 0;
        public int preLeft
        {
            get { return _preLeft; }
            set { _preLeft = value; }
        }

        public void UndoLocation()
        {
            if (_preTop != 0)
            {
                Top = _preTop;
                _preTop = 0;
            }
            if (_preLeft != 0)
            {
                Left = _preLeft;
            }
        }
    }
}
