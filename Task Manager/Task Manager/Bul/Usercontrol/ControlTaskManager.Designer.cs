namespace Task_Manager.Bul.Usercontrol
{
    partial class ControlTaskManager
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
            this.gridTask = new DevExpress.XtraGrid.GridControl();
            this.viewTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.group2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layout9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.repositoryItemMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemo)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.gridTask);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(942, 286, 650, 400);
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(1600, 698);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // gridTask
            // 
            this.gridTask.Location = new System.Drawing.Point(24, 49);
            this.gridTask.MainView = this.viewTask;
            this.gridTask.Name = "gridTask";
            this.gridTask.Size = new System.Drawing.Size(1552, 625);
            this.gridTask.TabIndex = 4;
            this.gridTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewTask});
            // 
            // viewTask
            // 
            this.viewTask.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewTask.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewTask.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.viewTask.GridControl = this.gridTask;
            this.viewTask.GroupPanelText = "Kéo thả tên cột vào khu vực này để nhóm lịch trình";
            this.viewTask.Name = "viewTask";
            this.viewTask.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.viewTask.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.viewTask.OptionsBehavior.Editable = false;
            this.viewTask.OptionsCustomization.AllowFilter = false;
            this.viewTask.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewTask.OptionsFind.AlwaysVisible = true;
            this.viewTask.OptionsFind.FindNullPrompt = "Tìm kiếm";
            this.viewTask.OptionsFind.ShowClearButton = false;
            this.viewTask.OptionsFind.ShowCloseButton = false;
            this.viewTask.OptionsFind.ShowFindButton = false;
            this.viewTask.OptionsMenu.EnableColumnMenu = false;
            this.viewTask.OptionsMenu.EnableFooterMenu = false;
            this.viewTask.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewTask.OptionsView.RowAutoHeight = true;
            this.viewTask.OptionsView.ShowGroupedColumns = true;
            this.viewTask.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.viewTask.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.ViewTask_RowStyle);
            this.viewTask.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.ViewTask_PopupMenuShowing);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.group2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1600, 698);
            this.Root.TextVisible = false;
            // 
            // group2
            // 
            this.group2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layout9});
            this.group2.Location = new System.Drawing.Point(0, 0);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(1580, 678);
            this.group2.Text = "Lịch trình công việc";
            // 
            // layout9
            // 
            this.layout9.Control = this.gridTask;
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
            // ControlTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "ControlTaskManager";
            this.Size = new System.Drawing.Size(1600, 698);
            this.VisibleChanged += new System.EventHandler(this.ControlTaskManager_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraGrid.GridControl gridTask;
        private DevExpress.XtraGrid.Views.Grid.GridView viewTask;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layout9;
        private DevExpress.XtraLayout.LayoutControlGroup group2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemo;
    }
}
