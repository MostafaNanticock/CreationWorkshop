﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UV_DLP_3D_Printer.GUI.Controls;
using OpenTK.Graphics;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform.Windows;
using UV_DLP_3D_Printer._3DEngine;

namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    public class ctlUserPanel : UserControl
    {
        public ctl3DView c3d = null;
        public ctlBgnd bgndPanel = new ctlBgnd();
        //public int panelWidth = 14;
        String mGuiAnchor;
        String mGLBackgroundImage;
        protected String mStyleName;
#if (DEBUG) // DBG_GUICONFIG
        protected GuiControlStyle mStyle;
#else
        protected ControlStyle mStyle;
#endif
        protected int mGapx, mGapy;
        protected bool mGLVisible;


        public ctlUserPanel()
            : base()
        {
            bgndPanel.col = Color.Navy;
            bgndPanel.imageName = null;
            mGLVisible = false;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (mGLVisible)
                    cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        // will apear in properties panel
        [Description("Horizontal space from anchored location"), Category("Anchoring")]
        public int Gapx
        {
            get { return mGapx; }
            set { mGapx = value; }
        }
        [Description("Vertical space from anchored location"), Category("Data")]
        public int Gapy
        {
            get { return mGapy; }
            set { mGapy = value; }
        }

        [Description("GUI anchor type, 2 letter combination of t,c,b and l,c,r"), Category("Data")]
        public String GuiAnchor
        {
            get { return mGuiAnchor; }
            set { mGuiAnchor = value; }
        }

        [Description("Determine if control is visible in GL view"), Category("Data")]
        public bool GLVisible
        {
            get { return mGLVisible; }
            set {
                if (mGLVisible != value)
                {
                    mGLVisible = value;
                    DoubleBuffered = !mGLVisible;
                    RecreateHandle();
                }
            }
        }

        [Description("GL background image name"), Category("Data")]
        public String GLBackgroundImage
        {
            get { return mGLBackgroundImage; }
            set
            {
                mGLBackgroundImage = value;
            }
        }

        [Description("Control display style name"), Category("Data")]
        public String StyleName
        {
            get { return mStyleName; }
            set
            {
                mStyleName = value;
                mStyle = null;
            }
        }

#if (DEBUG) // DBG_GUICONFIG
        public virtual GuiControlStyle Style
#else
        public virtual ControlStyle Style
#endif
        {
            get
            {
                if (mStyle == null)
                    mStyle = UVDLPApp.Instance().m_gui_config.GetControlStyle(mStyleName);
                if (mStyle == null)
                    return UVDLPApp.Instance().m_gui_config.DefaultControlStyle;
                return mStyle;
            }
        }

        void UpdatePanelLocation()
        {
            bgndPanel.x = Location.X - Style.PanelPad.Left;
            bgndPanel.y = Location.Y - Style.PanelPad.Top;
            bgndPanel.w = Width + Style.PanelPad.Left + Style.PanelPad.Right;
            bgndPanel.h = Height + Style.PanelPad.Top + Style.PanelPad.Bottom;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (c3d != null)
            {
                if (Visible)
                {
                    UpdatePanelLocation();
                    c3d.ctlBgndList.Add(bgndPanel);
                }
                else
                {
                    c3d.ctlBgndList.Remove(bgndPanel);
                }
                c3d.Refresh();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (!Visible)
                return;
            UpdatePanelLocation();
            if (c3d != null)
                c3d.Refresh();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            if (!Visible)
                return;
            UpdatePanelLocation();
            if (c3d != null)
                c3d.Refresh();
        }

#if (DEBUG) // DBG_GUICONFIG
        public void ApplyStyleRecurse(Control ctl, GuiControlStyle ct)
#else
        public void ApplyStyleRecurse(Control ctl, ControlStyle ct)
#endif
        {
            foreach (Control subctl in ctl.Controls)
            {
                if (subctl is ctlUserPanel)
                {
                    ((ctlUserPanel)subctl).ApplyStyle(ct);
                }
                else
                {
                    ApplyStyleRecurse(subctl, ct);
                }
            }
        }


#if (DEBUG) // DBG_GUICONFIG
        // new gui system -SHS
        public virtual void ApplyStyle(ControlStyle ct) { }  // dummy fuction to eliminate compilation errors 
        public virtual void ApplyStyle(GuiControlStyle ct)
        {
            mStyle = ct;
            mStyleName = ct.Name;
            ApplyStyleRecurse(this, ct);
            if (ct.BackColor.IsValid())
                bgndPanel.col = ct.BackColor;
            if (ct.BackImage.IsValid())
                bgndPanel.imageName = ct.BackImage;
        }
#else
        public virtual void ApplyStyle(GuiControlStyle ct) { }   // dummy fuction to eliminate compilation errors 
        public virtual void ApplyStyle(ControlStyle ct)
        {
            mStyle = ct;
            mStyleName = ct.Name;
            ApplyStyleRecurse(this, ct);
            if (ct.BackColor != ControlStyle.NullColor)
                bgndPanel.col = ct.BackColor;
            if (ct.BackImage != null)
                bgndPanel.imageName = ct.BackImage;
        }
#endif

        public virtual void GLRedraw(C2DGraphics gr, int x, int y)
        {
            if (!GLVisible || !Visible)
                return;
            gr.SetDrawingRegion(x, y, Width, Height);
            OnGLBackgroundPaint(gr);
            OnGLPaint(gr);
            foreach (Control subctl in Controls)
            {
                if (subctl.GetType().IsSubclassOf(typeof(ctlUserPanel)))
                {
                    ((ctlUserPanel)subctl).GLRedraw(gr, x + subctl.Location.X, y + subctl.Location.Y);
                }
            }
        }

        public virtual void GLRedraw(C2DGraphics gr)
        {
            GLRedraw(gr, Location.X, Location.Y);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (GLVisible)
                return;
            Brush br = new SolidBrush(Style.BackColor);
            e.Graphics.FillRectangle(br, 0, 0, Width, Height);
            //base.OnPaintBackground(e);
        }

        public virtual void OnGLPaint(C2DGraphics gr)
        {
        }

        public virtual void OnGLBackgroundPaint(C2DGraphics gr)
        {
            if (mGLBackgroundImage != null)
            {
                gr.Panel9(mGLBackgroundImage, 0, 0, Width, Height);
                return;
            }
            gr.Rectangle(0, 0, Width, Height, Style.BackColor);
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            if (mGLVisible)
            {
                UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eReDraw2D, "");
                return;
            }
            base.OnInvalidated(e);
        }
    }
}
