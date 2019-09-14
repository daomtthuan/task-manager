namespace Task_Manager.Bul.Form
{
    partial class FormAccount
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEmail = new DevExpress.XtraEditors.TextEdit();
            this.textPhone = new DevExpress.XtraEditors.TextEdit();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.textId = new DevExpress.XtraEditors.TextEdit();
            this.textUsername = new DevExpress.XtraEditors.TextEdit();
            this.textRoll = new DevExpress.XtraEditors.TextEdit();
            this.buttonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem4 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem5 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem6 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRoll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEmail);
            this.layoutControl1.Controls.Add(this.textPhone);
            this.layoutControl1.Controls.Add(this.textName);
            this.layoutControl1.Controls.Add(this.textId);
            this.layoutControl1.Controls.Add(this.textUsername);
            this.layoutControl1.Controls.Add(this.textRoll);
            this.layoutControl1.Controls.Add(this.buttonSubmit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(393, 388);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(12, 306);
            this.textEmail.Name = "textEmail";
            this.textEmail.Properties.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(369, 26);
            this.textEmail.StyleController = this.layoutControl1;
            this.textEmail.TabIndex = 6;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(12, 252);
            this.textPhone.Name = "textPhone";
            this.textPhone.Properties.ReadOnly = true;
            this.textPhone.Size = new System.Drawing.Size(369, 26);
            this.textPhone.StyleController = this.layoutControl1;
            this.textPhone.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 144);
            this.textName.Name = "textName";
            this.textName.Properties.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(369, 26);
            this.textName.StyleController = this.layoutControl1;
            this.textName.TabIndex = 3;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(12, 90);
            this.textId.Name = "textId";
            this.textId.Properties.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(369, 26);
            this.textId.StyleController = this.layoutControl1;
            this.textId.TabIndex = 2;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(12, 36);
            this.textUsername.Name = "textUsername";
            this.textUsername.Properties.Mask.EditMask = "\\p{Ll}+";
            this.textUsername.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textUsername.Properties.Mask.ShowPlaceHolders = false;
            this.textUsername.Properties.MaxLength = 100;
            this.textUsername.Properties.ReadOnly = true;
            this.textUsername.Size = new System.Drawing.Size(369, 26);
            this.textUsername.StyleController = this.layoutControl1;
            this.textUsername.TabIndex = 1;
            // 
            // textRoll
            // 
            this.textRoll.Location = new System.Drawing.Point(12, 198);
            this.textRoll.Name = "textRoll";
            this.textRoll.Properties.ReadOnly = true;
            this.textRoll.Size = new System.Drawing.Size(369, 26);
            this.textRoll.StyleController = this.layoutControl1;
            this.textRoll.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.buttonSubmit.Appearance.Options.UseBackColor = true;
            this.buttonSubmit.Location = new System.Drawing.Point(12, 346);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(369, 30);
            this.buttonSubmit.StyleController = this.layoutControl1;
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Đống";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.simpleLabelItem1,
            this.simpleLabelItem2,
            this.simpleLabelItem3,
            this.simpleLabelItem4,
            this.simpleLabelItem5,
            this.simpleLabelItem6,
            this.layoutControlItem12,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(393, 388);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textUsername;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(373, 30);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textId;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(373, 30);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.textRoll;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 186);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(373, 30);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.textName;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(373, 30);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.textPhone;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(373, 30);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(373, 24);
            this.simpleLabelItem1.Text = "Tên đăng nhập";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(102, 20);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 54);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(373, 24);
            this.simpleLabelItem2.Text = "Mã số";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(102, 20);
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.AllowHotTrack = false;
            this.simpleLabelItem3.Location = new System.Drawing.Point(0, 108);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Size = new System.Drawing.Size(373, 24);
            this.simpleLabelItem3.Text = "Họ tên";
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(102, 20);
            // 
            // simpleLabelItem4
            // 
            this.simpleLabelItem4.AllowHotTrack = false;
            this.simpleLabelItem4.Location = new System.Drawing.Point(0, 162);
            this.simpleLabelItem4.Name = "simpleLabelItem4";
            this.simpleLabelItem4.Size = new System.Drawing.Size(373, 24);
            this.simpleLabelItem4.Text = "Chức vụ";
            this.simpleLabelItem4.TextSize = new System.Drawing.Size(102, 20);
            // 
            // simpleLabelItem5
            // 
            this.simpleLabelItem5.AllowHotTrack = false;
            this.simpleLabelItem5.Location = new System.Drawing.Point(0, 216);
            this.simpleLabelItem5.Name = "simpleLabelItem5";
            this.simpleLabelItem5.Size = new System.Drawing.Size(373, 24);
            this.simpleLabelItem5.Text = "Số điện thoại";
            this.simpleLabelItem5.TextSize = new System.Drawing.Size(102, 20);
            // 
            // simpleLabelItem6
            // 
            this.simpleLabelItem6.AllowHotTrack = false;
            this.simpleLabelItem6.Location = new System.Drawing.Point(0, 270);
            this.simpleLabelItem6.Name = "simpleLabelItem6";
            this.simpleLabelItem6.Size = new System.Drawing.Size(373, 24);
            this.simpleLabelItem6.Text = "Email";
            this.simpleLabelItem6.TextSize = new System.Drawing.Size(102, 20);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.textEmail;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 294);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(373, 30);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.buttonSubmit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 324);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(49, 39);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 12, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(373, 44);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FormAccount
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 388);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAccount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRoll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEmail;
        private DevExpress.XtraEditors.TextEdit textPhone;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.TextEdit textId;
        private DevExpress.XtraEditors.TextEdit textUsername;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.TextEdit textRoll;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem3;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem4;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem5;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem6;
        private DevExpress.XtraEditors.SimpleButton buttonSubmit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}