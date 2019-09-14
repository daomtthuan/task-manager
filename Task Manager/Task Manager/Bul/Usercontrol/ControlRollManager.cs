using System;
using System.Windows.Forms;
using Task_Manager.Dto;
using Task_Manager.Dao;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using Task_Manager.Bul.Class;
using DevExpress.Utils;

namespace Task_Manager.Bul.Usercontrol
{
    public partial class ControlRollManager : DevExpress.XtraEditors.XtraUserControl
    {
        public ControlRollManager()
        {
            InitializeComponent();
        }

        public Roll GetFocusedRoll()
        {
            return (Roll)viewRoll.GetRow(viewRoll.FocusedRowHandle);
        }

        public GroupRoll GetFocusedGroupRoll()
        {
            return (GroupRoll)viewGroupRoll.GetRow(viewGroupRoll.FocusedRowHandle);
        }

        public void LoadRoll()
        {
            Cursor = Cursors.WaitCursor;
            gridRoll.DataSource = DaoRoll.Instance.GetRoll();
            viewRoll.PopulateColumns();
            viewRoll.Columns["Id"].Visible = false;
            viewRoll.Columns["Level"].Caption = "Cấp bậc";
            viewRoll.Columns["Level"].Width = 100;
            viewRoll.Columns["Level"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;
            viewRoll.Columns["Name"].Caption = "Chức vụ";
            viewRoll.Columns["Level"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            LoadToolRoll();
            Cursor = Cursors.Default;
        }

        public void LoadGroupRoll()
        {
            Cursor = Cursors.WaitCursor;
            gridGroupRoll.DataSource = DaoGroupRoll.Instance.GetAllGroupRoll();
            viewGroupRoll.PopulateColumns();
            viewGroupRoll.Columns["Id"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            viewGroupRoll.Columns["Id"].Visible = false;
            viewGroupRoll.Columns["Name"].Caption = "Tên nhóm chức vụ";
            LoadToolGroupRoll();
            Cursor = Cursors.Default;
        }

        public void LoadToolRoll()
        {
            Roll roll = GetFocusedRoll();
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonEdit"].Enabled = roll.Id != -1 && roll.Id != 0 && viewRoll.RowCount > 0;
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonDelete"].Enabled = roll.Id != -1 && roll.Id != 0 && viewRoll.RowCount > 0;
        }

        public void LoadToolGroupRoll()
        {
            GroupRoll group = GetFocusedGroupRoll();
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonEditGroupRoll"].Enabled = group.Id != 0 && viewGroupRoll.RowCount > 0;
            ((RibbonControl)ParentForm.Controls["ribbon"]).Items["buttonDeleteGroupRoll"].Enabled = group.Id != 0 && viewGroupRoll.RowCount > 0;
        }

        public void DeleteRoll()
        {
            XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Bạn có chắc muốn xoá chức vụ này này?", "Thông báo", new DialogResult[] { DialogResult.Yes, DialogResult.No });
            argsLoginMessageBox.Showing += Global.MessageBoxYesNo;
            if (XtraMessageBox.Show(argsLoginMessageBox) == DialogResult.No)
                return;
            else
            {
                Cursor = Cursors.WaitCursor;
                if (DaoRoll.Instance.DeleteRoll(((Roll)viewRoll.GetFocusedRow()).Id) == 0)
                {
                    argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Vì có nhân viên đang giữ chức vụ này nên hệ thống sẽ tự động chuyển chức vụ các nhân viên đó thành \"Chưa có chức vụ\"", "Thông báo", new DialogResult[] { DialogResult.OK });
                    argsLoginMessageBox.Showing += Global.MessageBoxOK;
                    XtraMessageBox.Show(argsLoginMessageBox);
                }

                LoadRoll();
                Cursor = Cursors.Default;
            }
        }

        public void DeleteGroupRoll()
        {
            XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Bạn có chắc muốn xoá nhóm chức vụ này này?", "Thông báo", new DialogResult[] { DialogResult.Yes, DialogResult.No });
            argsLoginMessageBox.Showing += Global.MessageBoxYesNo;
            if (XtraMessageBox.Show(argsLoginMessageBox) == DialogResult.No)
                return;
            else
            {
                Cursor = Cursors.WaitCursor;
                if (DaoGroupRoll.Instance.DeleteGroupRoll(((GroupRoll)viewGroupRoll.GetFocusedRow()).Id) == 0)
                {
                    argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Vì nhóm chức vụ này đã được phân công lịch trình nên hệ thống sẽ tự động chuyển các lịch trình đó thành \"Nhóm chưa có tên\"", "Thông báo", new DialogResult[] { DialogResult.OK });
                    argsLoginMessageBox.Showing += Global.MessageBoxOK;
                    XtraMessageBox.Show(argsLoginMessageBox);
                }
                LoadGroupRoll();
                Cursor = Cursors.Default;
            }
        }

        private void ViewRoll_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
                if ((int)((GridView)sender).GetRowCellValue(e.RowHandle, "Id") == -1)
                {
                    e.Appearance.ForeColor = DXSkinColors.FillColors.Danger;
                    e.HighPriority = true;
                }
                else if ((int)((GridView)sender).GetRowCellValue(e.RowHandle, "Id") == 0)
                {
                    e.Appearance.ForeColor = DXSkinColors.FillColors.Warning;
                    e.HighPriority = true;
                }
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

        private void ViewRoll_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadToolRoll();
        }

        private void ControlRollManager_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                LoadRoll();
                LoadGroupRoll();
            }
        }

        private void ViewGroupRoll_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadToolGroupRoll();
        }

        private void ViewGroupRoll_RowStyle(object sender, RowStyleEventArgs e)
        {
            if ((e.RowHandle >= 0) && (int)((GridView)sender).GetRowCellValue(e.RowHandle, "Id") == 0)
            {
                e.Appearance.ForeColor = DXSkinColors.FillColors.Danger;
                e.HighPriority = true;
            }
        }
    }
}
