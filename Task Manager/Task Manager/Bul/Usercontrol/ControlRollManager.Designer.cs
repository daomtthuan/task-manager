namespace Task_Manager.Bul.Usercontrol
{
    partial class ControlRollManager
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
            this.gridRoll = new DevExpress.XtraGrid.GridControl();
            this.viewRoll = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridGroupRoll = new DevExpress.XtraGrid.GridControl();
            this.viewGroupRoll = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.group1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layout1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.group2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layout2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.repositoryItemMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGroupRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemo)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.gridRoll);
            this.layoutControl.Controls.Add(this.gridGroupRoll);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(942, 286, 650, 400);
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(1600, 698);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // gridRoll
            // 
            this.gridRoll.Location = new System.Drawing.Point(24, 49);
            this.gridRoll.MainView = this.viewRoll;
            this.gridRoll.Name = "gridRoll";
            this.gridRoll.Size = new System.Drawing.Size(762, 625);
            this.gridRoll.TabIndex = 4;
            this.gridRoll.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewRoll});
            // 
            // viewRoll
            // 
            this.viewRoll.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewRoll.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewRoll.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.viewRoll.GridControl = this.gridRoll;
            this.viewRoll.Name = "viewRoll";
            this.viewRoll.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.viewRoll.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.viewRoll.OptionsBehavior.Editable = false;
            this.viewRoll.OptionsCustomization.AllowColumnMoving = false;
            this.viewRoll.OptionsCustomization.AllowFilter = false;
            this.viewRoll.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.True;
            this.viewRoll.OptionsFind.AlwaysVisible = true;
            this.viewRoll.OptionsFind.FindNullPrompt = "Tìm kiếm";
            this.viewRoll.OptionsFind.ShowClearButton = false;
            this.viewRoll.OptionsFind.ShowCloseButton = false;
            this.viewRoll.OptionsFind.ShowFindButton = false;
            this.viewRoll.OptionsMenu.EnableColumnMenu = false;
            this.viewRoll.OptionsMenu.EnableFooterMenu = false;
            this.viewRoll.OptionsMenu.EnableGroupPanelMenu = false;
            this.viewRoll.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewRoll.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.viewRoll.OptionsView.RowAutoHeight = true;
            this.viewRoll.OptionsView.ShowGroupPanel = false;
            this.viewRoll.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.ViewRoll_RowStyle);
            this.viewRoll.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewRoll_FocusedRowChanged);
            // 
            // gridGroupRoll
            // 
            this.gridGroupRoll.Location = new System.Drawing.Point(814, 49);
            this.gridGroupRoll.MainView = this.viewGroupRoll;
            this.gridGroupRoll.Name = "gridGroupRoll";
            this.gridGroupRoll.Size = new System.Drawing.Size(762, 625);
            this.gridGroupRoll.TabIndex = 4;
            this.gridGroupRoll.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewGroupRoll});
            // 
            // viewGroupRoll
            // 
            this.viewGroupRoll.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewGroupRoll.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewGroupRoll.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.viewGroupRoll.GridControl = this.gridGroupRoll;
            this.viewGroupRoll.Name = "viewGroupRoll";
            this.viewGroupRoll.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.viewGroupRoll.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.viewGroupRoll.OptionsBehavior.Editable = false;
            this.viewGroupRoll.OptionsCustomization.AllowColumnMoving = false;
            this.viewGroupRoll.OptionsCustomization.AllowFilter = false;
            this.viewGroupRoll.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.True;
            this.viewGroupRoll.OptionsCustomization.AllowSort = false;
            this.viewGroupRoll.OptionsFind.AlwaysVisible = true;
            this.viewGroupRoll.OptionsFind.FindNullPrompt = "Tìm kiếm";
            this.viewGroupRoll.OptionsFind.ShowClearButton = false;
            this.viewGroupRoll.OptionsFind.ShowCloseButton = false;
            this.viewGroupRoll.OptionsFind.ShowFindButton = false;
            this.viewGroupRoll.OptionsMenu.EnableColumnMenu = false;
            this.viewGroupRoll.OptionsMenu.EnableFooterMenu = false;
            this.viewGroupRoll.OptionsMenu.EnableGroupPanelMenu = false;
            this.viewGroupRoll.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewGroupRoll.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.viewGroupRoll.OptionsView.RowAutoHeight = true;
            this.viewGroupRoll.OptionsView.ShowGroupPanel = false;
            this.viewGroupRoll.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.ViewGroupRoll_RowStyle);
            this.viewGroupRoll.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewGroupRoll_FocusedRowChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.group1,
            this.group2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1600, 698);
            this.Root.TextVisible = false;
            // 
            // group1
            // 
            this.group1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layout1});
            this.group1.Location = new System.Drawing.Point(0, 0);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(790, 678);
            this.group1.Text = "Danh sách chức vụ";
            // 
            // layout1
            // 
            this.layout1.Control = this.gridRoll;
            this.layout1.CustomizationFormText = "layout9";
            this.layout1.Location = new System.Drawing.Point(0, 0);
            this.layout1.Name = "layout1";
            this.layout1.Size = new System.Drawing.Size(766, 629);
            this.layout1.Text = "layout9";
            this.layout1.TextSize = new System.Drawing.Size(0, 0);
            this.layout1.TextVisible = false;
            // 
            // group2
            // 
            this.group2.CustomizationFormText = "Danh sách nhóm chức vụ";
            this.group2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layout2});
            this.group2.Location = new System.Drawing.Point(790, 0);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(790, 678);
            this.group2.Text = "Danh sách nhóm chức vụ";
            // 
            // layout2
            // 
            this.layout2.Control = this.gridGroupRoll;
            this.layout2.CustomizationFormText = "layout9";
            this.layout2.Location = new System.Drawing.Point(0, 0);
            this.layout2.Name = "layout2";
            this.layout2.Size = new System.Drawing.Size(766, 629);
            this.layout2.Text = "layout9";
            this.layout2.TextSize = new System.Drawing.Size(0, 0);
            this.layout2.TextVisible = false;
            // 
            // repositoryItemMemo
            // 
            this.repositoryItemMemo.Name = "repositoryItemMemo";
            // 
            // ControlRollManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "ControlRollManager";
            this.Size = new System.Drawing.Size(1600, 698);
            this.VisibleChanged += new System.EventHandler(this.ControlRollManager_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGroupRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemo;
        private DevExpress.XtraGrid.GridControl gridRoll;
        private DevExpress.XtraGrid.Views.Grid.GridView viewRoll;
        private DevExpress.XtraLayout.LayoutControlGroup group1;
        private DevExpress.XtraLayout.LayoutControlItem layout1;
        private DevExpress.XtraGrid.GridControl gridGroupRoll;
        private DevExpress.XtraGrid.Views.Grid.GridView viewGroupRoll;
        private DevExpress.XtraLayout.LayoutControlGroup group2;
        private DevExpress.XtraLayout.LayoutControlItem layout2;
    }
}
