using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using Task_Manager.Dao;
using Task_Manager.Bul.Class;
using Task_Manager.Bul.Form;
using Task_Manager.Dto;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;

namespace Task_Manager.Bul.Usercontrol
{
    public partial class ControlTaskManager : XtraUserControl
    {
        private bool isCanExport = true;

        public ControlTaskManager()
        {
            InitializeComponent();
        }

        public Task GetFocusedTask()
        {
            return (Task)viewTask.GetRow(viewTask.FocusedRowHandle);
        }

        public void DeleteTask()
        {
            XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Bạn có chắc muốn xoá lịch trình này?", "Thông báo", new DialogResult[] { DialogResult.Yes, DialogResult.No });
            argsLoginMessageBox.Showing += Global.MessageBoxYesNo;
            if (XtraMessageBox.Show(argsLoginMessageBox) == DialogResult.No)
                return;
            else
            {
                Cursor = Cursors.WaitCursor;
                DaoTask.Instance.DeleteTask(((Task)viewTask.GetFocusedRow()).Id);
                LoadTask();
                Cursor = Cursors.Default;
            }
        }

        public void LoadTask()
        {
            if (((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateFrom"]).EditValue != null && ((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateTo"]).EditValue != null)
            {
                Cursor = Cursors.WaitCursor;
                isCanExport = true;
                List<Task> data = DaoTask.Instance.GetTask((DateTime)((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateFrom"]).EditValue, (DateTime)((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateTo"]).EditValue);
                gridTask.DataSource = data;
                viewTask.PopulateColumns();
                viewTask.Columns["Id"].Visible = false;
                viewTask.Columns["ObjectId"].Caption = "Mã số";
                viewTask.Columns["ObjectId"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;
                viewTask.Columns["ObjectId"].Width = 70;
                viewTask.Columns["Name"].Caption = "Nhân viên / Nhóm chức vụ";
                viewTask.Columns["RollId"].Visible = false;
                viewTask.Columns["RollName"].Caption = "Chức vụ";
                viewTask.Columns["Time"].Caption = "Thời gian";
                viewTask.Columns["Time"].DisplayFormat.FormatType = FormatType.DateTime;
                viewTask.Columns["Time"].DisplayFormat.FormatString = "ddd dd/MM/yyyy HH:mm";
                viewTask.Columns["Time"].GroupFormat.FormatType = FormatType.DateTime;
                viewTask.Columns["Time"].GroupFormat.FormatString = "ddd, dd/MM/yyyy";
                viewTask.Columns["Location"].Caption = "Địa điểm";
                viewTask.Columns["Location"].ColumnEdit = repositoryItemMemo;
                viewTask.Columns["Content"].Caption = "Công việc";
                viewTask.Columns["Content"].ColumnEdit = repositoryItemMemo;
                viewTask.Columns["Note"].Caption = "Ghi chú";
                viewTask.Columns["Note"].ColumnEdit = repositoryItemMemo;
                LoadTool();
                Parent.Tag = data;
                Cursor = Cursors.Default;
            }
        }

        public void LoadTool()
        {
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonEdit"].Enabled = viewTask.RowCount > 0;
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonDelete"].Enabled = viewTask.RowCount > 0;
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonExportWord"].Enabled = viewTask.RowCount > 0 && isCanExport;
        }

        public void ExpandGroup()
        {
            Cursor = Cursors.WaitCursor;
            viewTask.ExpandAllGroups();
            Cursor = Cursors.Default;
        }

        public void CollapseGroup()
        {
            Cursor = Cursors.WaitCursor;
            viewTask.CollapseAllGroups();
            Cursor = Cursors.Default;
        }

        public void UnGroup()
        {
            Cursor = Cursors.WaitCursor;
            viewTask.ClearGrouping();
            Cursor = Cursors.Default;
        }

        public void Group()
        {
            Cursor = Cursors.WaitCursor;
            viewTask.ClearGrouping();
            viewTask.Columns["Time"].Group();
            Cursor = Cursors.Default;
        }

        public void DateFrom()
        {
            Cursor = Cursors.WaitCursor;
            LoadTask();
            Cursor = Cursors.Default;
        }

        public void DateTo()
        {
            Cursor = Cursors.WaitCursor;
            LoadTask();
            Cursor = Cursors.Default;
        }

        public void ViewWeek()
        {
            Cursor = Cursors.WaitCursor;
            ((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateFrom"]).EditValue = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            ((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateTo"]).EditValue = DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(7);
            viewTask.Columns["Time"].GroupFormat.FormatString = "ddd, dd/MM/yyyy";
            viewTask.Columns["Time"].Group();
            Cursor = Cursors.Default;
        }

        public void ViewMonth()
        {
            Cursor = Cursors.WaitCursor;
            ((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateFrom"]).EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).StartOfWeek(DayOfWeek.Monday);
            ((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateTo"]).EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)).StartOfWeek(DayOfWeek.Monday).AddDays(7);
            viewTask.Columns["Time"].GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Date;
            viewTask.Columns["Time"].GroupFormat.FormatString = "ddd, dd/MM/yyyy";
            viewTask.Columns["Time"].Group();
            Cursor = Cursors.Default;
        }

        public void ViewYear()
        {
            Cursor = Cursors.WaitCursor;
            ((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateFrom"]).EditValue = new DateTime(DateTime.Now.Year, 1, 1).StartOfWeek(DayOfWeek.Monday);
            ((BarEditItem)((RibbonControl)ParentForm.Controls["ribbon"]).Items["dateTo"]).EditValue = new DateTime(DateTime.Now.Year, 12, 31).StartOfWeek(DayOfWeek.Monday).AddDays(7);
            viewTask.Columns["Time"].GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth;
            viewTask.Columns["Time"].GroupFormat.FormatString = "MM/yyyy";
            viewTask.Columns["Time"].Group();
            Cursor = Cursors.Default;
        }

        private void ViewTask_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
                if (((GridView)sender).GetRowCellValue(e.RowHandle, "RollId").ToString() == "-1" || (int)((GridView)sender).GetRowCellValue(e.RowHandle, "ObjectId") == 0)
                {
                    e.Appearance.ForeColor = DXSkinColors.FillColors.Danger;
                    e.HighPriority = true;
                    isCanExport = false;
                }
                else if (((GridView)sender).GetRowCellValue(e.RowHandle, "RollId").ToString() == "0")
                {
                    e.Appearance.ForeColor = DXSkinColors.FillColors.Warning;
                    e.HighPriority = true;
                }
        }

        private void ViewTask_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Group)
            {
                e.Menu.Items[0].Caption = "Mở rộng";
                e.Menu.Items[1].Caption = "Thu gọn";
                e.Menu.Items[2].Caption = "Xoá nhóm";
                e.Menu.Items[3].Visible = false;
            }
        }

        private void ControlTaskManager_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible) LoadTask();
        }
    }
}
