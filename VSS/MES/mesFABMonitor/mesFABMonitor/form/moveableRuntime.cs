﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace mesFABMonitor
{
    public class moveableRuntime
    {
        //////////////////////////////////////////////////////////////////
        // PRIVATE CONSTANTS AND VARIABLES
        //////////////////////////////////////////////////////////////////

        private const int BOX_SIZE = 7;
        private Color BOX_COLOR = Color.White;
        private Control m_control;
        private Label[] lbl = new Label[8];
        private int startl;
        private int startt;
        private int startw;
        private int starth;
        private int startx;
        private int starty;
        private bool dragging;
        private Cursor[] arrArrow = new Cursor[] {Cursors.SizeNWSE, Cursors.SizeNS,
			Cursors.SizeNESW, Cursors.SizeWE, Cursors.SizeNWSE, Cursors.SizeNS,
			Cursors.SizeNESW, Cursors.SizeWE};
        private Cursor oldCursor;
        private Control _parent = null;

        private const int MIN_SIZE = 5;

        //
        // Constructor creates 8 sizing handles & wires mouse events
        // to each that implement sizing functions
        //
        public moveableRuntime(Control parent)
        {
            _parent = parent;
            for (int i = 0; i < 8; i++)
            {
                lbl[i] = new Label();
                lbl[i].TabIndex = i;
                lbl[i].FlatStyle = 0;
                lbl[i].BorderStyle = BorderStyle.FixedSingle;
                lbl[i].BackColor = BOX_COLOR;               
                lbl[i].Cursor = arrArrow[i];
                lbl[i].Text = "";
                lbl[i].BringToFront();
                lbl[i].MouseDown += new MouseEventHandler(this.lbl_MouseDown);
                lbl[i].MouseMove += new MouseEventHandler(this.lbl_MouseMove);
                lbl[i].MouseUp += new MouseEventHandler(this.lbl_MouseUp);
                lbl[i].Hide();
                _parent.Controls.Add(lbl[i]);
            }
        }

        //////////////////////////////////////////////////////////////////
        // PUBLIC METHODS
        //////////////////////////////////////////////////////////////////

        //
        // Wires a Click event handler to the passed Control
        // that attaches a pick box to the control when it is clicked
        //
        public void WireControl(Control ctl)
        {
            ctl.Click += new EventHandler(this.SelectControl);
        }

        public Control SelectedControl
        {
            get { return m_control; }
        }

        bool isActive = true;
        public bool IsActive
        {
            get { return isActive; }
            set
            {
                isActive = value;
                if (m_control == null)
                {
                    isActive = false;
                    return;
                }
                BOX_COLOR = isActive ? Color.White : Color.Black;
                for (int i = 0; i < 8; i++)
                {
                    lbl[i].BackColor = BOX_COLOR;
                    if (isActive)
                        lbl[i].BringToFront();
                }
            }
        }

        /////////////////////////////////////////////////////////////////
        // PRIVATE METHODS
        /////////////////////////////////////////////////////////////////

        //
        // Attaches a pick box to the sender Control
        //
        private void SelectControl(object sender, EventArgs e)
        {
            SelectControl(sender);           
        }

        public void SelectControl(object sender)
        {
            _parent.SuspendLayout();
            if (m_control is Control)
            {
                m_control.Cursor = oldCursor;

                //Remove event any pre-existing event handlers appended by this class
                m_control.MouseDown -= new MouseEventHandler(this.ctl_MouseDown);
                m_control.MouseMove -= new MouseEventHandler(this.ctl_MouseMove);
                m_control.MouseUp -= new MouseEventHandler(this.ctl_MouseUp);

                m_control = null;
            }

            if (sender == null)
            {
                Remove();
                return;
            }

            HideHandles();
            m_control = (Control)sender;
            //Add event handlers for moving the selected control around
            m_control.MouseDown += new MouseEventHandler(this.ctl_MouseDown);
            m_control.MouseMove += new MouseEventHandler(this.ctl_MouseMove);
            m_control.MouseUp += new MouseEventHandler(this.ctl_MouseUp);

            //Add sizing handles to Control's container (Form or PictureBox)
            for (int i = 0; i < 8; i++)
            {
                if (!_parent.Controls.Contains(lbl[i]))
                    _parent.Controls.Add(lbl[i]);
                lbl[i].BringToFront();
            }

            //Position sizing handles around Control
            MoveHandles();

            //Display sizing handles
            ShowHandles();

            _parent.ResumeLayout(true);
            oldCursor = m_control.Cursor;
            m_control.Cursor = Cursors.SizeAll;
        }

        public void PreviewKeyDown(Keys key, bool shift)
        {
            if (m_control == null) return;
            switch (key)
            {
                case Keys.Down:
                    if (shift)
                        m_control.Height++;
                    else
                        m_control.Top++;
                    break;
                case Keys.Up:
                    if (shift)
                        m_control.Height--;
                    else
                        m_control.Top--;
                    break;
                case Keys.Left:
                    if (shift)
                        m_control.Width--;
                    else
                        m_control.Left--;
                    break;
                case Keys.Right:
                    if (shift)
                        m_control.Width++;
                    else
                        m_control.Left++;
                    break;
                default:
                    return;
            }
            MoveHandles();
        }

        public void Remove()
        {
            HideHandles();
            if (m_control != null)
                m_control.Cursor = oldCursor;
        }

        public void Clear()
        {
            for (int i = 0; i < 8; i++)
            {
                _parent.Controls.Remove(lbl[i]);
            }
            _parent = null;
        }

        private void ShowHandles()
        {
            if (m_control != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    lbl[i].Visible = true;
                }
            }
        }

        private void HideHandles()
        {
            for (int i = 0; i < 8; i++)
            {
                lbl[i].Visible = false;
            }
        }

        public void MoveHandles()
        {
            int sX = m_control.Left - BOX_SIZE;
            int sY = m_control.Top - BOX_SIZE;
            int sW = m_control.Width + BOX_SIZE;
            int sH = m_control.Height + BOX_SIZE;
            int hB = BOX_SIZE / 2;
            int[] arrPosX = new int[] {sX+hB, sX + sW / 2, sX + sW-hB, sX + sW-hB,
			sX + sW-hB, sX + sW / 2, sX+hB, sX+hB};
            int[] arrPosY = new int[] {sY+hB, sY+hB, sY+hB, sY + sH / 2, sY + sH-hB,
			sY + sH-hB, sY + sH-hB, sY + sH / 2};
            for (int i = 0; i < 8; i++)
                lbl[i].SetBounds(arrPosX[i], arrPosY[i], BOX_SIZE, BOX_SIZE);
        }

        /////////////////////////////////////////////////////////////////
        // MOUSE EVENTS THAT IMPLEMENT SIZING OF THE PICKED CONTROL
        /////////////////////////////////////////////////////////////////

        //
        // Store control position and size when mouse button pushed over
        // any sizing handle
        //
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startl = m_control.Left;
            startt = m_control.Top;
            startw = m_control.Width;
            starth = m_control.Height;
            HideHandles();
        }

        //
        // Size the picked control in accordance with sizing handle being dragged
        //	0   1   2
        //  7       3
        //  6   5   4
        //
        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            int l = m_control.Left;
            int w = m_control.Width;
            int t = m_control.Top;
            int h = m_control.Height;
            if (dragging)
            {
                switch (((Label)sender).TabIndex)
                {
                    case 0: // Dragging top-left sizing box
                        l = startl + e.X < startl + startw - MIN_SIZE ? startl + e.X : startl + startw - MIN_SIZE;
                        t = startt + e.Y < startt + starth - MIN_SIZE ? startt + e.Y : startt + starth - MIN_SIZE;
                        w = startl + startw - m_control.Left;
                        h = startt + starth - m_control.Top;
                        break;
                    case 1: // Dragging top-center sizing box
                        t = startt + e.Y < startt + starth - MIN_SIZE ? startt + e.Y : startt + starth - MIN_SIZE;
                        h = startt + starth - m_control.Top;
                        break;
                    case 2: // Dragging top-right sizing box
                        w = startw + e.X > MIN_SIZE ? startw + e.X : MIN_SIZE;
                        t = startt + e.Y < startt + starth - MIN_SIZE ? startt + e.Y : startt + starth - MIN_SIZE;
                        h = startt + starth - m_control.Top;
                        break;
                    case 3: // Dragging right-middle sizing box
                        w = startw + e.X > MIN_SIZE ? startw + e.X : MIN_SIZE;
                        break;
                    case 4: // Dragging right-bottom sizing box
                        w = startw + e.X > MIN_SIZE ? startw + e.X : MIN_SIZE;
                        h = starth + e.Y > MIN_SIZE ? starth + e.Y : MIN_SIZE;
                        break;
                    case 5: // Dragging center-bottom sizing box
                        h = starth + e.Y > MIN_SIZE ? starth + e.Y : MIN_SIZE;
                        break;
                    case 6: // Dragging left-bottom sizing box
                        l = startl + e.X < startl + startw - MIN_SIZE ? startl + e.X : startl + startw - MIN_SIZE;
                        w = startl + startw - m_control.Left;
                        h = starth + e.Y > MIN_SIZE ? starth + e.Y : MIN_SIZE;
                        break;
                    case 7: // Dragging left-middle sizing box
                        l = startl + e.X < startl + startw - MIN_SIZE ? startl + e.X : startl + startw - MIN_SIZE;
                        w = startl + startw - m_control.Left;
                        break;
                }
                l = (l < 0) ? 0 : l;
                t = (t < 0) ? 0 : t;
                m_control.SetBounds(l, t, w, h);
            }
        }

        //
        // Display sizing handles around picked control once sizing has completed
        //
        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            MoveHandles();
            ShowHandles();
        }

        /////////////////////////////////////////////////////////////////
        // MOUSE EVENTS THAT MOVE THE PICKED CONTROL AROUND THE FORM
        /////////////////////////////////////////////////////////////////

        //
        // Get mouse pointer starting position on mouse down and hide sizing handles
        //
        public void ctl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startx = e.X;
            starty = e.Y;
            HideHandles();
        }

        //
        // Reposition the dragged control
        //
        public void ctl_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                int l = m_control.Left + e.X - startx;
                int t = m_control.Top + e.Y - starty;
                int w = m_control.Width;
                int h = m_control.Height;
                l = (l < 0) ? 0 : ((l + w >_parent.ClientRectangle.Width) ?
                  _parent.ClientRectangle.Width - w : l);
                t = (t < 0) ? 0 : ((t + h > _parent.ClientRectangle.Height) ?
                _parent.ClientRectangle.Height - h : t);
                m_control.Left = l;
                m_control.Top = t;
            }
        }

        //
        // Display sizing handles around picked control once dragging has completed
        //
        private void ctl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            MoveHandles();
            ShowHandles();
        }
    }
}
