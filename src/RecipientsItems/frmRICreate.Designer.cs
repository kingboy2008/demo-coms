using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.RecipientsItems
{
    partial class frmRICreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRICreate()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.txtITEM_NAME = new Smobiler.Core.Controls.TextBox();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.txtITEM_QTY = new Smobiler.Core.Controls.TextBox();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.dpkITEM_DATE = new Smobiler.Core.Controls.DatePicker();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtITEM_USER = new Smobiler.Core.Controls.TextBox();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.txtITEM_NOTE = new Smobiler.Core.Controls.TextBox();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.imgbtnSignature = new Smobiler.Core.Controls.ImageButton();
            this.Signature1 = new Smobiler.Core.Controls.Signature();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "��Ʒ����";
            this.Label1.ZIndex = 1;
            // 
            // txtITEM_NAME
            // 
            this.txtITEM_NAME.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtITEM_NAME.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtITEM_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtITEM_NAME.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtITEM_NAME.Location = new Smobiler.Core.PointS(35F, 0F);
            this.txtITEM_NAME.Name = "txtITEM_NAME";
            this.txtITEM_NAME.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtITEM_NAME.Size = new System.Drawing.SizeF(85F, 14F);
            this.txtITEM_NAME.TabIndex = 3;
            this.txtITEM_NAME.WaterMarkText = "�����䣩";
            this.txtITEM_NAME.ZIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "��Ʒ����";
            this.Label2.ZIndex = 3;
            // 
            // txtITEM_QTY
            // 
            this.txtITEM_QTY.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtITEM_QTY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtITEM_QTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtITEM_QTY.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtITEM_QTY.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtITEM_QTY.Location = new Smobiler.Core.PointS(35F, 14F);
            this.txtITEM_QTY.Name = "txtITEM_QTY";
            this.txtITEM_QTY.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtITEM_QTY.Size = new System.Drawing.SizeF(85F, 14F);
            this.txtITEM_QTY.TabIndex = 5;
            this.txtITEM_QTY.WaterMarkText = "0";
            this.txtITEM_QTY.ZIndex = 4;
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new Smobiler.Core.PointS(0F, 31F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "����ʱ��";
            this.Label3.ZIndex = 5;
            // 
            // dpkITEM_DATE
            // 
            this.dpkITEM_DATE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.dpkITEM_DATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkITEM_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkITEM_DATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpkITEM_DATE.Location = new Smobiler.Core.PointS(35F, 31F);
            this.dpkITEM_DATE.Name = "dpkITEM_DATE";
            this.dpkITEM_DATE.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.dpkITEM_DATE.Size = new System.Drawing.SizeF(85F, 14F);
            this.dpkITEM_DATE.TabIndex = 7;
            this.dpkITEM_DATE.ZIndex = 6;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new Smobiler.Core.PointS(0F, 45F);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "������";
            this.Label4.ZIndex = 7;
            // 
            // txtITEM_USER
            // 
            this.txtITEM_USER.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtITEM_USER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtITEM_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtITEM_USER.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtITEM_USER.Location = new Smobiler.Core.PointS(35F, 45F);
            this.txtITEM_USER.Name = "txtITEM_USER";
            this.txtITEM_USER.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtITEM_USER.Size = new System.Drawing.SizeF(85F, 14F);
            this.txtITEM_USER.TabIndex = 9;
            this.txtITEM_USER.WaterMarkText = "�����䣩";
            this.txtITEM_USER.ZIndex = 8;
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new Smobiler.Core.PointS(0F, 62F);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "��ע";
            this.Label5.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // txtITEM_NOTE
            // 
            this.txtITEM_NOTE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtITEM_NOTE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtITEM_NOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtITEM_NOTE.Location = new Smobiler.Core.PointS(35F, 62F);
            this.txtITEM_NOTE.Multiline = true;
            this.txtITEM_NOTE.Name = "txtITEM_NOTE";
            this.txtITEM_NOTE.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.txtITEM_NOTE.Size = new System.Drawing.SizeF(85F, 40F);
            this.txtITEM_NOTE.TabIndex = 11;
            this.txtITEM_NOTE.WaterMarkText = "��ѡ�";
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label6.Location = new Smobiler.Core.PointS(0F, 105F);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label6.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "������ǩ��";
            this.Label6.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // imgbtnSignature
            // 
            this.imgbtnSignature.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.imgbtnSignature.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgbtnSignature.FontSize = 4F;
            this.imgbtnSignature.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.imgbtnSignature.Location = new Smobiler.Core.PointS(35F, 105F);
            this.imgbtnSignature.Name = "imgbtnSignature";
            this.imgbtnSignature.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.imgbtnSignature.Size = new System.Drawing.SizeF(85F, 40F);
            this.imgbtnSignature.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbtnSignature.TabIndex = 13;
            this.imgbtnSignature.Text = "����ǩ����";
            this.imgbtnSignature.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnSignature_Click);
            // 
            // Signature1
            // 
            this.Signature1.Name = "Signature1";
            this.Signature1.SignatureCompleted += new Smobiler.Core.SignatureCompletedCallBackHandler(this.Signature1_SignatureCompleted);
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.Text = "����";
            // 
            // frmRICreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Signature1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.txtITEM_NAME,
            this.Label2,
            this.txtITEM_QTY,
            this.Label3,
            this.dpkITEM_DATE,
            this.Label4,
            this.txtITEM_USER,
            this.Label5,
            this.txtITEM_NOTE,
            this.Label6,
            this.imgbtnSignature});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "��Ʒ���ô���";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRICreate_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmRICreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmRICreate";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.TextBox txtITEM_NAME;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.TextBox txtITEM_QTY;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.DatePicker dpkITEM_DATE;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtITEM_USER;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.TextBox txtITEM_NOTE;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.ImageButton imgbtnSignature;
        internal Smobiler.Core.Controls.Signature Signature1;
        internal Smobiler.Core.Controls.ToolbarItem save;
        #endregion
    }
}