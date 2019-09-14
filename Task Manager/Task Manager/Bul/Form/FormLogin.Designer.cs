using Task_Manager.Properties;

namespace Task_Manager.Bul.Form
{
    partial class FromLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromLogin));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.buttonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.textUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelFormname = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layout1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutFromname = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFromname)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.buttonLogin);
            this.layoutControl1.Controls.Add(this.textPassword);
            this.layoutControl1.Controls.Add(this.textUsername);
            this.layoutControl1.Controls.Add(this.labelFormname);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(814, 110, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(364, 212);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.buttonLogin.Appearance.Options.UseBackColor = true;
            this.buttonLogin.Location = new System.Drawing.Point(12, 170);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(340, 30);
            this.buttonLogin.StyleController = this.layoutControl1;
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // textPassword
            // 
            this.textPassword.EditValue = "";
            this.textPassword.Location = new System.Drawing.Point(12, 130);
            this.textPassword.Name = "textPassword";
            this.textPassword.Properties.MaxLength = 100;
            this.textPassword.Properties.UseSystemPasswordChar = true;
            this.textPassword.Size = new System.Drawing.Size(340, 26);
            this.textPassword.StyleController = this.layoutControl1;
            this.textPassword.TabIndex = 2;
            // 
            // textUsername
            // 
            this.textUsername.EditValue = "";
            this.textUsername.Location = new System.Drawing.Point(12, 76);
            this.textUsername.Name = "textUsername";
            this.textUsername.Properties.Mask.EditMask = "\\p{Ll}+";
            this.textUsername.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textUsername.Properties.Mask.ShowPlaceHolders = false;
            this.textUsername.Properties.MaxLength = 100;
            this.textUsername.Size = new System.Drawing.Size(340, 26);
            this.textUsername.StyleController = this.layoutControl1;
            this.textUsername.TabIndex = 1;
            // 
            // labelFormname
            // 
            this.labelFormname.Appearance.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelFormname.Appearance.Options.UseFont = true;
            this.labelFormname.Appearance.Options.UseTextOptions = true;
            this.labelFormname.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelFormname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelFormname.Location = new System.Drawing.Point(13, 13);
            this.labelFormname.Name = "labelFormname";
            this.labelFormname.Size = new System.Drawing.Size(338, 28);
            this.labelFormname.StyleController = this.layoutControl1;
            this.labelFormname.TabIndex = 0;
            this.labelFormname.Text = "Quản lý lịch trình";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layout1,
            this.layout3,
            this.layout5,
            this.layout6,
            this.simpleLabelItem1,
            this.simpleLabelItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(364, 212);
            this.Root.TextVisible = false;
            // 
            // layout1
            // 
            this.layout1.Control = this.labelFormname;
            this.layout1.Location = new System.Drawing.Point(0, 0);
            this.layout1.Name = "layout1";
            this.layout1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 9);
            this.layout1.Size = new System.Drawing.Size(344, 40);
            this.layout1.TextSize = new System.Drawing.Size(0, 0);
            this.layout1.TextVisible = false;
            // 
            // layout3
            // 
            this.layout3.Control = this.textUsername;
            this.layout3.Location = new System.Drawing.Point(0, 64);
            this.layout3.Name = "layout3";
            this.layout3.Size = new System.Drawing.Size(344, 30);
            this.layout3.TextSize = new System.Drawing.Size(0, 0);
            this.layout3.TextVisible = false;
            // 
            // layout5
            // 
            this.layout5.Control = this.textPassword;
            this.layout5.Location = new System.Drawing.Point(0, 118);
            this.layout5.Name = "layout5";
            this.layout5.Size = new System.Drawing.Size(344, 30);
            this.layout5.TextSize = new System.Drawing.Size(0, 0);
            this.layout5.TextVisible = false;
            // 
            // layout6
            // 
            this.layout6.Control = this.buttonLogin;
            this.layout6.Location = new System.Drawing.Point(0, 158);
            this.layout6.MinSize = new System.Drawing.Size(87, 29);
            this.layout6.Name = "layout6";
            this.layout6.Size = new System.Drawing.Size(344, 34);
            this.layout6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout6.TextSize = new System.Drawing.Size(0, 0);
            this.layout6.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 40);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(344, 24);
            this.simpleLabelItem1.Text = "Tên đăng nhập";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(102, 20);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 94);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(344, 24);
            this.simpleLabelItem2.Text = "Mật khẩu";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(102, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 148);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(344, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutFromname
            // 
            this.layoutFromname.Control = this.labelFormname;
            this.layoutFromname.Location = new System.Drawing.Point(0, 0);
            this.layoutFromname.Name = "layoutControlItem2";
            this.layoutFromname.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 10);
            this.layoutFromname.Size = new System.Drawing.Size(342, 43);
            this.layoutFromname.TextSize = new System.Drawing.Size(0, 0);
            this.layoutFromname.TextVisible = false;
            // 
            // FromLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 212);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FromLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFromname)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton buttonLogin;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.TextEdit textUsername;
        private DevExpress.XtraEditors.LabelControl labelFormname;
        private DevExpress.XtraLayout.LayoutControlItem layout1;
        private DevExpress.XtraLayout.LayoutControlItem layout3;
        private DevExpress.XtraLayout.LayoutControlItem layout5;
        private DevExpress.XtraLayout.LayoutControlItem layout6;
        private DevExpress.XtraLayout.LayoutControlItem layoutFromname;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}