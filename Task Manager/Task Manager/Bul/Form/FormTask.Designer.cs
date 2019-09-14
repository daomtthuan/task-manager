namespace Task_Manager.Bul.Form
{
    partial class FormTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dateDateTime = new DevExpress.XtraEditors.DateEdit();
            this.textNote = new DevExpress.XtraEditors.MemoEdit();
            this.textLocation = new DevExpress.XtraEditors.TextEdit();
            this.textContent = new DevExpress.XtraEditors.MemoEdit();
            this.lookupObject = new DevExpress.XtraEditors.LookUpEdit();
            this.buttonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.radioIsEmployee = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layout2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem4 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem5 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem6 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupObject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioIsEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dateDateTime);
            this.layoutControl1.Controls.Add(this.textNote);
            this.layoutControl1.Controls.Add(this.textLocation);
            this.layoutControl1.Controls.Add(this.textContent);
            this.layoutControl1.Controls.Add(this.lookupObject);
            this.layoutControl1.Controls.Add(this.buttonSubmit);
            this.layoutControl1.Controls.Add(this.radioIsEmployee);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(431, 647);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dateDateTime
            // 
            this.dateDateTime.EditValue = null;
            this.dateDateTime.Location = new System.Drawing.Point(12, 152);
            this.dateDateTime.Name = "dateDateTime";
            this.dateDateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateTime.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dateDateTime.Properties.CalendarTimeProperties.Appearance.BackColor = System.Drawing.Color.White;
            this.dateDateTime.Properties.CalendarTimeProperties.Appearance.Options.UseBackColor = true;
            this.dateDateTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateTime.Properties.CalendarTimeProperties.Mask.EditMask = "HH:mm";
            this.dateDateTime.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = true;
            this.dateDateTime.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateDateTime.Properties.Mask.EditMask = "ddd dd/MM/yyyy HH:mm";
            this.dateDateTime.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateDateTime.Properties.MaxLength = 19;
            this.dateDateTime.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateDateTime.Size = new System.Drawing.Size(407, 26);
            this.dateDateTime.StyleController = this.layoutControl1;
            this.dateDateTime.TabIndex = 2;
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(12, 480);
            this.textNote.Name = "textNote";
            this.textNote.Properties.MaxLength = 250;
            this.textNote.Size = new System.Drawing.Size(407, 111);
            this.textNote.StyleController = this.layoutControl1;
            this.textNote.TabIndex = 5;
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(12, 206);
            this.textLocation.Name = "textLocation";
            this.textLocation.Properties.MaxLength = 250;
            this.textLocation.Size = new System.Drawing.Size(407, 26);
            this.textLocation.StyleController = this.layoutControl1;
            this.textLocation.TabIndex = 3;
            // 
            // textContent
            // 
            this.textContent.Location = new System.Drawing.Point(12, 260);
            this.textContent.Name = "textContent";
            this.textContent.Properties.MaxLength = 500;
            this.textContent.Size = new System.Drawing.Size(407, 192);
            this.textContent.StyleController = this.layoutControl1;
            this.textContent.TabIndex = 4;
            // 
            // lookupObject
            // 
            this.lookupObject.Location = new System.Drawing.Point(12, 98);
            this.lookupObject.Name = "lookupObject";
            this.lookupObject.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.lookupObject.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lookupObject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupObject.Properties.DropDownRows = 20;
            this.lookupObject.Properties.MaxLength = 100;
            this.lookupObject.Properties.NullText = "";
            this.lookupObject.Properties.PopupWidth = 900;
            this.lookupObject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupObject.Size = new System.Drawing.Size(407, 26);
            this.lookupObject.StyleController = this.layoutControl1;
            this.lookupObject.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.buttonSubmit.Appearance.Options.UseBackColor = true;
            this.buttonSubmit.Location = new System.Drawing.Point(12, 605);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(407, 30);
            this.buttonSubmit.StyleController = this.layoutControl1;
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Thêm lịch trình";
            // 
            // radioIsEmployee
            // 
            this.radioIsEmployee.EditValue = true;
            this.radioIsEmployee.Location = new System.Drawing.Point(12, 36);
            this.radioIsEmployee.Name = "radioIsEmployee";
            this.radioIsEmployee.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioIsEmployee.Properties.Appearance.Options.UseBackColor = true;
            this.radioIsEmployee.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioIsEmployee.Properties.Columns = 2;
            this.radioIsEmployee.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioIsEmployee.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Nhân viên"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Nhóm chức vụ")});
            this.radioIsEmployee.Size = new System.Drawing.Size(407, 34);
            this.radioIsEmployee.StyleController = this.layoutControl1;
            this.radioIsEmployee.TabIndex = 7;
            this.radioIsEmployee.SelectedIndexChanged += new System.EventHandler(this.RadioIsEmployee_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layout2,
            this.layout8,
            this.layout4,
            this.layout6,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.simpleLabelItem1,
            this.simpleLabelItem3,
            this.simpleLabelItem2,
            this.simpleLabelItem4,
            this.simpleLabelItem5,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.simpleLabelItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(431, 647);
            this.Root.TextVisible = false;
            // 
            // layout2
            // 
            this.layout2.Control = this.dateDateTime;
            this.layout2.CustomizationFormText = "layout2";
            this.layout2.Location = new System.Drawing.Point(0, 140);
            this.layout2.Name = "layout2";
            this.layout2.Size = new System.Drawing.Size(411, 30);
            this.layout2.TextSize = new System.Drawing.Size(0, 0);
            this.layout2.TextVisible = false;
            // 
            // layout8
            // 
            this.layout8.Control = this.textNote;
            this.layout8.CustomizationFormText = "layout8";
            this.layout8.Location = new System.Drawing.Point(0, 468);
            this.layout8.Name = "layout8";
            this.layout8.Size = new System.Drawing.Size(411, 115);
            this.layout8.TextSize = new System.Drawing.Size(0, 0);
            this.layout8.TextVisible = false;
            // 
            // layout4
            // 
            this.layout4.Control = this.textLocation;
            this.layout4.CustomizationFormText = "layout4";
            this.layout4.Location = new System.Drawing.Point(0, 194);
            this.layout4.Name = "layout4";
            this.layout4.Size = new System.Drawing.Size(411, 30);
            this.layout4.TextSize = new System.Drawing.Size(0, 0);
            this.layout4.TextVisible = false;
            // 
            // layout6
            // 
            this.layout6.Control = this.textContent;
            this.layout6.CustomizationFormText = "layout6";
            this.layout6.Location = new System.Drawing.Point(0, 248);
            this.layout6.Name = "layout6";
            this.layout6.Size = new System.Drawing.Size(411, 196);
            this.layout6.TextSize = new System.Drawing.Size(0, 0);
            this.layout6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookupObject;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(411, 30);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.buttonSubmit;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 593);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(115, 29);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(411, 34);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.CustomizationFormText = "Nhân viên *";
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 62);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem1.Text = "Nhân viên *";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(121, 20);
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.AllowHotTrack = false;
            this.simpleLabelItem3.CustomizationFormText = "Thời gian *";
            this.simpleLabelItem3.Location = new System.Drawing.Point(0, 116);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem3.Text = "Thời gian *";
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(121, 20);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.CustomizationFormText = "Địa điểm";
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 170);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem2.Text = "Địa điểm";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(121, 20);
            // 
            // simpleLabelItem4
            // 
            this.simpleLabelItem4.AllowHotTrack = false;
            this.simpleLabelItem4.CustomizationFormText = "Công việc *";
            this.simpleLabelItem4.Location = new System.Drawing.Point(0, 224);
            this.simpleLabelItem4.Name = "simpleLabelItem4";
            this.simpleLabelItem4.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem4.Text = "Công việc";
            this.simpleLabelItem4.TextSize = new System.Drawing.Size(121, 20);
            // 
            // simpleLabelItem5
            // 
            this.simpleLabelItem5.AllowHotTrack = false;
            this.simpleLabelItem5.CustomizationFormText = "Ghi chú";
            this.simpleLabelItem5.Location = new System.Drawing.Point(0, 444);
            this.simpleLabelItem5.Name = "simpleLabelItem5";
            this.simpleLabelItem5.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem5.Text = "Ghi chú";
            this.simpleLabelItem5.TextSize = new System.Drawing.Size(121, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 583);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(411, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioIsEmployee;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(411, 38);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleLabelItem6
            // 
            this.simpleLabelItem6.AllowHotTrack = false;
            this.simpleLabelItem6.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem6.Name = "simpleLabelItem6";
            this.simpleLabelItem6.Size = new System.Drawing.Size(411, 24);
            this.simpleLabelItem6.Text = "Chọn đối tượng *";
            this.simpleLabelItem6.TextSize = new System.Drawing.Size(121, 20);
            // 
            // FormTask
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 647);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTask";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lịch trình";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateDateTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupObject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioIsEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit dateDateTime;
        private DevExpress.XtraEditors.MemoEdit textNote;
        private DevExpress.XtraEditors.TextEdit textLocation;
        private DevExpress.XtraEditors.MemoEdit textContent;
        private DevExpress.XtraEditors.LookUpEdit lookupObject;
        private DevExpress.XtraEditors.SimpleButton buttonSubmit;
        private DevExpress.XtraLayout.LayoutControlItem layout2;
        private DevExpress.XtraLayout.LayoutControlItem layout8;
        private DevExpress.XtraLayout.LayoutControlItem layout4;
        private DevExpress.XtraLayout.LayoutControlItem layout6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem3;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem4;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.RadioGroup radioIsEmployee;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem6;
    }
}