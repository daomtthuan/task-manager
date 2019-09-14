namespace Task_Manager.Bul.Form
{
    partial class FormEmployee
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
            this.textPhone = new DevExpress.XtraEditors.TextEdit();
            this.buttonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.lookupRoll = new DevExpress.XtraEditors.LookUpEdit();
            this.textEmail = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layout2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem4 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupRoll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textPhone);
            this.layoutControl1.Controls.Add(this.buttonSubmit);
            this.layoutControl1.Controls.Add(this.textName);
            this.layoutControl1.Controls.Add(this.lookupRoll);
            this.layoutControl1.Controls.Add(this.textEmail);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(431, 280);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(12, 144);
            this.textPhone.Name = "textPhone";
            this.textPhone.Properties.Mask.EditMask = "\\d*";
            this.textPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textPhone.Properties.Mask.ShowPlaceHolders = false;
            this.textPhone.Properties.MaxLength = 20;
            this.textPhone.Size = new System.Drawing.Size(407, 26);
            this.textPhone.StyleController = this.layoutControl1;
            this.textPhone.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.buttonSubmit.Appearance.Options.UseBackColor = true;
            this.buttonSubmit.Location = new System.Drawing.Point(12, 238);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(407, 30);
            this.buttonSubmit.StyleController = this.layoutControl1;
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Thêm nhân viên";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 36);
            this.textName.Name = "textName";
            this.textName.Properties.Mask.EditMask = "\\p{L}+( \\p{L}{1,})+";
            this.textName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textName.Properties.Mask.ShowPlaceHolders = false;
            this.textName.Properties.MaxLength = 100;
            this.textName.Size = new System.Drawing.Size(407, 26);
            this.textName.StyleController = this.layoutControl1;
            this.textName.TabIndex = 1;
            // 
            // lookupRoll
            // 
            this.lookupRoll.Location = new System.Drawing.Point(12, 90);
            this.lookupRoll.Name = "lookupRoll";
            this.lookupRoll.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.lookupRoll.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lookupRoll.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupRoll.Properties.DropDownRows = 20;
            this.lookupRoll.Properties.MaxLength = 100;
            this.lookupRoll.Properties.NullText = "";
            this.lookupRoll.Properties.PopupWidth = 600;
            this.lookupRoll.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookupRoll.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupRoll.Size = new System.Drawing.Size(407, 26);
            this.lookupRoll.StyleController = this.layoutControl1;
            this.lookupRoll.TabIndex = 2;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(12, 198);
            this.textEmail.Name = "textEmail";
            this.textEmail.Properties.Mask.EditMask = "[a-z][a-z0-9_\\.]{5,32}@[a-z0-9]{2,}(\\.[a-z0-9]{2,4})+";
            this.textEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEmail.Properties.Mask.ShowPlaceHolders = false;
            this.textEmail.Properties.MaxLength = 100;
            this.textEmail.Size = new System.Drawing.Size(407, 26);
            this.textEmail.StyleController = this.layoutControl1;
            this.textEmail.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layout2,
            this.layout4,
            this.layout6,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.simpleLabelItem1,
            this.simpleLabelItem3,
            this.simpleLabelItem2,
            this.simpleLabelItem4,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(431, 280);
            this.Root.TextVisible = false;
            // 
            // layout2
            // 
            this.layout2.Control = this.lookupRoll;
            this.layout2.CustomizationFormText = "layout2";
            this.layout2.Location = new System.Drawing.Point(0, 78);
            this.layout2.Name = "layout2";
            this.layout2.Size = new System.Drawing.Size(411, 30);
            this.layout2.TextSize = new System.Drawing.Size(0, 0);
            this.layout2.TextVisible = false;
            // 
            // layout4
            // 
            this.layout4.Control = this.textPhone;
            this.layout4.CustomizationFormText = "layout4";
            this.layout4.Location = new System.Drawing.Point(0, 132);
            this.layout4.Name = "layout4";
            this.layout4.Size = new System.Drawing.Size(411, 30);
            this.layout4.TextSize = new System.Drawing.Size(0, 0);
            this.layout4.TextVisible = false;
            // 
            // layout6
            // 
            this.layout6.Control = this.textEmail;
            this.layout6.CustomizationFormText = "layout6";
            this.layout6.Location = new System.Drawing.Point(0, 186);
            this.layout6.Name = "layout6";
            this.layout6.Size = new System.Drawing.Size(411, 30);
            this.layout6.TextSize = new System.Drawing.Size(0, 0);
            this.layout6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textName;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(411, 30);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.buttonSubmit;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 226);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(122, 29);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(411, 34);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem1.Text = "Họ tên *";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(90, 20);
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.AllowHotTrack = false;
            this.simpleLabelItem3.Location = new System.Drawing.Point(0, 54);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem3.Text = "Chức vụ *";
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(90, 20);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 108);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem2.Text = "Số điện thoại";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(90, 20);
            // 
            // simpleLabelItem4
            // 
            this.simpleLabelItem4.AllowHotTrack = false;
            this.simpleLabelItem4.Location = new System.Drawing.Point(0, 162);
            this.simpleLabelItem4.Name = "simpleLabelItem4";
            this.simpleLabelItem4.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem4.Text = "Email";
            this.simpleLabelItem4.TextSize = new System.Drawing.Size(90, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 216);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(411, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormEmployee
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 280);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupRoll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textPhone;
        private DevExpress.XtraEditors.SimpleButton buttonSubmit;
        private DevExpress.XtraLayout.LayoutControlItem layout2;
        private DevExpress.XtraLayout.LayoutControlItem layout4;
        private DevExpress.XtraLayout.LayoutControlItem layout6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem3;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.LookUpEdit lookupRoll;
        private DevExpress.XtraEditors.TextEdit textEmail;
    }
}