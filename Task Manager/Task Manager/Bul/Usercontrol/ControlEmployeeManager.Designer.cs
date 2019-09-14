namespace Task_Manager.Bul.Usercontrol
{
    partial class ControlEmployeeManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.gridEmployee = new DevExpress.XtraGrid.GridControl();
            this.viewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.group = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layout9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.repositoryItemMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemo)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.gridEmployee);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(942, 286, 650, 400);
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(1600, 698);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // gridEmployee
            // 
            this.gridEmployee.Location = new System.Drawing.Point(24, 49);
            this.gridEmployee.MainView = this.viewEmployee;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.Size = new System.Drawing.Size(1552, 625);
            this.gridEmployee.TabIndex = 4;
            this.gridEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewEmployee});
            // 
            // viewEmployee
            // 
            this.viewEmployee.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewEmployee.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewEmployee.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.viewEmployee.GridControl = this.gridEmployee;
            this.viewEmployee.GroupPanelText = "Kéo thả tên cột vào khu vực này để nhóm nhân viên";
            this.viewEmployee.Name = "viewEmployee";
            this.viewEmployee.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.viewEmployee.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.viewEmployee.OptionsBehavior.Editable = false;
            this.viewEmployee.OptionsCustomization.AllowFilter = false;
            this.viewEmployee.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewEmployee.OptionsFind.AlwaysVisible = true;
            this.viewEmployee.OptionsFind.FindNullPrompt = "Tìm kiếm";
            this.viewEmployee.OptionsFind.ShowClearButton = false;
            this.viewEmployee.OptionsFind.ShowCloseButton = false;
            this.viewEmployee.OptionsFind.ShowFindButton = false;
            this.viewEmployee.OptionsMenu.EnableColumnMenu = false;
            this.viewEmployee.OptionsMenu.EnableFooterMenu = false;
            this.viewEmployee.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewEmployee.OptionsView.RowAutoHeight = true;
            this.viewEmployee.OptionsView.ShowGroupedColumns = true;
            this.viewEmployee.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.ViewEmployee_RowStyle);
            this.viewEmployee.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.ViewEmployee_PopupMenuShowing);
            this.viewEmployee.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewEmployee_FocusedRowChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.group});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1600, 698);
            this.Root.TextVisible = false;
            // 
            // group
            // 
            this.group.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layout9});
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(1580, 678);
            this.group.Text = "Danh sách nhân viên";
            // 
            // layout9
            // 
            this.layout9.Control = this.gridEmployee;
            this.layout9.Location = new System.Drawing.Point(0, 0);
            this.layout9.Name = "layout9";
            this.layout9.Size = new System.Drawing.Size(1556, 629);
            this.layout9.TextSize = new System.Drawing.Size(0, 0);
            this.layout9.TextVisible = false;
            // 
            // repositoryItemMemo
            // 
            this.repositoryItemMemo.Name = "repositoryItemMemo";
            // 
            // ControlEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "ControlEmployeeManager";
            this.Size = new System.Drawing.Size(1600, 698);
            this.VisibleChanged += new System.EventHandler(this.ControlEmployeeManager_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraGrid.GridControl gridEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView viewEmployee;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layout9;
        private DevExpress.XtraLayout.LayoutControlGroup group;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemo;
    }
}
