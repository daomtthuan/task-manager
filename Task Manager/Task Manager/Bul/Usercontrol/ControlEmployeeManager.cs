using System;
using System.Windows.Forms;
using Task_Manager.Dao;
using DevExpress.Utils;
using Task_Manager.Dto;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using Task_Manager.Bul.Class;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid;

namespace Task_Manager.Bul.Usercontrol
{
    public partial class ControlEmployeeManager : XtraUserControl
    {
        public ControlEmployeeManager()
        {
            InitializeComponent();
        }

        public Account GetFocusedEmployee()
        {
            return (Account)viewEmployee.GetRow(viewEmployee.FocusedRowHandle);
        }

        public void LoadEmployee()
        {
            Cursor = Cursors.WaitCursor;
            gridEmployee.DataSource = DaoEmployee.Instance.GetEmployeeWithAccount();
            viewEmployee.PopulateColumns();
            viewEmployee.Columns["Id"].Caption = "Mã số";
            viewEmployee.Columns["Id"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;
            viewEmployee.Columns["Id"].Width = 70;
            viewEmployee.Columns["Username"].Caption = "Tài khoản";
            viewEmployee.Columns["Username"].Width = 150;
            viewEmployee.Columns["Name"].Caption = "Họ tên";
            viewEmployee.Columns["RollId"].Visible = false;
            viewEmployee.Columns["RollLevel"].Caption = "Cấp bậc";
            viewEmployee.Columns["RollLevel"].Width = 100;
            viewEmployee.Columns["RollName"].Caption = "Chức vụ";
            viewEmployee.Columns["RollLevel"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            viewEmployee.Columns["RollLevel"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;
            viewEmployee.Columns["Phone"].Caption = "Số điện thoại";
            viewEmployee.Columns["Email"].Caption = "Email";
            LoadTool();
            Cursor = Cursors.Default;
        }

        public void LoadTool()
        {
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonEdit"].Enabled = viewEmployee.RowCount > 0;
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonDelete"].Enabled = viewEmployee.RowCount > 0;
            Account account = GetFocusedEmployee();
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonAddAccount"].Enabled = account.Username == "" && account.RollId != 0 && viewEmployee.RowCount > 0;
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonResetPassword"].Enabled = account.Username != "" && viewEmployee.RowCount > 0;
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonDeleteAccount"].Enabled = Global.account.Id != account.Id && account.Username != "" && viewEmployee.RowCount > 0;
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonDelete"].Enabled = Global.account.Id != account.Id && viewEmployee.RowCount > 0;
        }

        public void ResetPassword()
        {
            Cursor = Cursors.WaitCursor;
            DaoAccount.Instance.ResetPassword(GetFocusedEmployee().Id);
            Cursor = Cursors.Default;
        }

        public void DeleteAccount()
        {
            XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Bạn có chắc muốn xoá tài khoản của nhân viên này?", "Thông báo", new DialogResult[] { DialogResult.Yes, DialogResult.No });
            argsLoginMessageBox.Showing += Global.MessageBoxYesNo;
            if (XtraMessageBox.Show(argsLoginMessageBox) == DialogResult.No)
                return;
            else
            {
                Cursor = Cursors.WaitCursor;
                DaoAccount.Instance.DeleteAccount(GetFocusedEmployee().Id);
                LoadEmployee();
                Cursor = Cursors.Default;
            }
        }

        public void ExpandGroup()
        {
            viewEmployee.ExpandAllGroups();
        }

        public void CollapseGroup()
        {
            viewEmployee.CollapseAllGroups();
        }

        public void UnGroup()
        {
            viewEmployee.ClearGrouping();
        }

        public void Group()
        {
            viewEmployee.ClearGrouping();
            viewEmployee.Columns["RollName"].Group();
        }

        public void DeleteEmployee()
        {
            XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Bạn có chắc muốn xoá nhân viên này?", "Thông báo", new DialogResult[] { DialogResult.Yes, DialogResult.No });
            argsLoginMessageBox.Showing += Global.MessageBoxYesNo;
            if (XtraMessageBox.Show(argsLoginMessageBox) == DialogResult.No)
                return;
            else
            {
                Cursor = Cursors.WaitCursor;
                if (DaoEmployee.Instance.DeleteEmployee(((Account)viewEmployee.GetFocusedRow()).Id) == 0)
                {
                    argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Nhân viên này đã được phân công lịch trình\nĐể đảm bảo thông tin được lưu trữ, hệ thống tự động chuyển chức vụ của nhân viên này thành \"Nghỉ việc\"\n" +
                        "Để xoá nhân viên này, vui lòng thay đổi nhân viên thực hiện các lịch trình của nhân viên này hoặc xoá chúng đi", "Thông báo", new DialogResult[] { DialogResult.OK });
                    argsLoginMessageBox.Showing += Global.MessageBoxOK;
                    XtraMessageBox.Show(argsLoginMessageBox);
                }
                LoadEmployee();
                Cursor = Cursors.Default;
            }
        }

        private void ViewEmployee_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
                if ((int)((GridView)sender).GetRowCellValue(e.RowHandle, "RollId") == -1)
                {
                    e.Appearance.ForeColor = DXSkinColors.FillColors.Danger;
                    e.HighPriority = true;
                }
                else if ((int)((GridView)sender).GetRowCellValue(e.RowHandle, "RollId") == 0)
                {
                    e.Appearance.ForeColor = DXSkinColors.FillColors.Warning;
                    e.HighPriority = true;
                }
        }

        private void ViewEmployee_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadTool();
        }

        private void ViewEmployee_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Group)
            {
                e.Menu.Items[0].Caption = "Mở rộng";
                e.Menu.Items[1].Caption = "Thu gọn";
                e.Menu.Items[2].Caption = "Xoá nhóm";
                e.Menu.Items[3].Visible = false;
            }
        }

        private void ControlEmployeeManager_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible) LoadEmployee();
        }
    }
}
