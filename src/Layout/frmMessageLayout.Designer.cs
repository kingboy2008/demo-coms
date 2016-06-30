﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Message
{
    public partial class frmMessageLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmMessageLayout()
            : base()
        {

            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lblNOTE = new Smobiler.Core.Controls.Label();
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.lblNOTE1 = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblNOTE
            // 
            this.lblNOTE.DataMember = "NO";
            this.lblNOTE.DisplayMember = "NOTE";
            this.lblNOTE.FontSize = 7F;
            this.lblNOTE.Location = new Smobiler.Core.PointS(18F, 0F);
            this.lblNOTE.Name = "lblNOTE";
            this.lblNOTE.Size = new System.Drawing.SizeF(102F, 12F);
            this.lblNOTE.TabIndex = 3;
            this.lblNOTE.ZIndex = 2;
            // 
            // Image1
            // 
            this.Image1.BorderColor = System.Drawing.Color.Gainsboro;
            this.Image1.BorderRadius = 4;
            this.Image1.DataMember = "STATEDESC";
            this.Image1.DisplayMember = "STATEDESC";
            this.Image1.Location = new Smobiler.Core.PointS(2F, 3F);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.SizeF(14F, 14F);
            this.Image1.TabIndex = 5;
            this.Image1.ZIndex = 1;
            // 
            // lblNOTE1
            // 
            this.lblNOTE1.DataMember = "STATE";
            this.lblNOTE1.DisplayMember = "NOTE1";
            this.lblNOTE1.FontSize = 5F;
            this.lblNOTE1.ForeColor = System.Drawing.Color.Gray;
            this.lblNOTE1.Location = new Smobiler.Core.PointS(18F, 12F);
            this.lblNOTE1.Name = "lblNOTE1";
            this.lblNOTE1.Size = new System.Drawing.SizeF(102F, 8F);
            this.lblNOTE1.TabIndex = 6;
            this.lblNOTE1.ZIndex = 3;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new Smobiler.Core.PointS(0F, 20F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line1.TabIndex = 7;
            this.Line1.ZIndex = 4;
            // 
            // frmMessageLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image1,
            this.lblNOTE,
            this.lblNOTE1,
            this.Line1});
            this.Size = new System.Drawing.Size(120, 20);

        }
        internal Smobiler.Core.Controls.Label lblNOTE;
        internal Smobiler.Core.Controls.Image Image1;
        internal Smobiler.Core.Controls.Label lblNOTE1;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion

    }


}