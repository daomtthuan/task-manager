using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Task_Manager.Bul.Class;
using Task_Manager.Bul.Usercontrol;
using Task_Manager.Dto;

namespace Task_Manager.Bul.Form
{
    public partial class FormMain : RibbonForm
    {
        private ControlTaskManager controlTaskManager;
        private ControlEmployeeManager controlEmployeeManager;
        private ControlRollManager controlRollManager;
        private bool SkipMessageBoxExitOrLogout = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SkipMessageBoxExitOrLogout)
            {
                XtraMessageBoxArgs argsExitMessageBox = new XtraMessageBoxArgs(null, null, "Bạn có chắc muốn thoát hay chỉ đăng xuất?", "Thông báo", new DialogResult[] { DialogResult.Yes, DialogResult.No, DialogResult.Retry });
                argsExitMessageBox.Showing += Global.MessageBoxExitOrLogout;
                DialogResult dialogResult = XtraMessageBox.Show(argsExitMessageBox);
                if (dialogResult == DialogResult.No)
                    e.Cancel = true;
                else if (dialogResult == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    Global.isExit = true;
                    SkipMessageBoxExitOrLogout = true;
                }
                else Cursor = Cursors.WaitCursor;
            }
        }

        private void HideAll()
        {
            controlTaskManager.Hide();
            controlEmployeeManager.Hide();
            controlRollManager.Hide();
        }

        private void ButtonTaskPage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            HideAll();
            controlTaskManager.Show();
            groupAccount.Visible = false;
            groupGrouping.Visible = true;
            groupView.Visible = true;
            groupReport.Visible = true;
            groupGroupRoll.Visible = false;
            buttonGroup.Caption = "Nhóm\nlịch trình";
            buttonAdd.Caption = "Thêm\nlịch trình";
            buttonEdit.Caption = "Sửa\nlịch trình";
            buttonDelete.Caption = "Xoá\nlịch trình";
            ((ToolTipTitleItem)buttonGroup.SuperTip.Items[0]).Text = "Nhóm lịch trình";
            ((ToolTipItem)buttonGroup.SuperTip.Items[1]).Text = "Nhóm các lịch trình theo thời gian";
            ((ToolTipTitleItem)buttonAdd.SuperTip.Items[0]).Text = "Thêm lịch trình";
            ((ToolTipItem)buttonAdd.SuperTip.Items[1]).Text = "Thêm một lịch trình mới";
            ((ToolTipTitleItem)buttonEdit.SuperTip.Items[0]).Text = "Sửa lịch trình";
            ((ToolTipItem)buttonEdit.SuperTip.Items[1]).Text = "Sửa lịch trình đang chọn";
            ((ToolTipTitleItem)buttonDelete.SuperTip.Items[0]).Text = "Xoá lịch trình";
            ((ToolTipItem)buttonDelete.SuperTip.Items[1]).Text = "Xoá lịch trình đang chọn";
            Cursor = Cursors.Default;
        }

        private void ButtonEmployeePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            HideAll();
            controlEmployeeManager.Show();
            groupAccount.Visible = true;
            groupGrouping.Visible = true;
            groupView.Visible = false;
            groupReport.Visible = false;
            groupGroupRoll.Visible = false;
            buttonAdd.Caption = "Thêm\nnhân viên";
            buttonEdit.Caption = "Sửa\nnhân viên";
            buttonDelete.Caption = "Xoá\nnhân viên";
            buttonGroup.Caption = "Nhóm\nnhân viên";
            ((ToolTipTitleItem)buttonGroup.SuperTip.Items[0]).Text = "Nhóm nhân viên";
            ((ToolTipItem)buttonGroup.SuperTip.Items[1]).Text = "Nhóm các nhân viên theo chức vụ";
            ((ToolTipTitleItem)buttonAdd.SuperTip.Items[0]).Text = "Thêm nhân viên";
            ((ToolTipItem)buttonAdd.SuperTip.Items[1]).Text = "Thêm một nhân viên mới";
            ((ToolTipTitleItem)buttonEdit.SuperTip.Items[0]).Text = "Sửa nhân viên";
            ((ToolTipItem)buttonEdit.SuperTip.Items[1]).Text = "Sửa thông tin nhân viên đang chọn";
            ((ToolTipTitleItem)buttonDelete.SuperTip.Items[0]).Text = "Xoá nhân viên";
            ((ToolTipItem)buttonDelete.SuperTip.Items[1]).Text = "Xoá nhân viên đang chọn\nNếu nhân viên đó đã được phân công lịch trình, tự động chuyển chức vụ của nhân viên thành \"Nghỉ việc\"";
            Cursor = Cursors.Default;
        }

        private void ButtonRollPage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            HideAll();
            controlRollManager.Show();
            groupAccount.Visible = false;
            groupGrouping.Visible = false;
            groupView.Visible = false;
            groupReport.Visible = false;
            groupGroupRoll.Visible = true;
            buttonAdd.Caption = "Thêm\nchức vụ";
            buttonEdit.Caption = "Sửa\nchức vụ";
            buttonDelete.Caption = "Xoá\nchức vụ";
            ((ToolTipTitleItem)buttonAdd.SuperTip.Items[0]).Text = "Thêm chức vụ";
            ((ToolTipItem)buttonAdd.SuperTip.Items[1]).Text = "Thêm một chức vụ mới";
            ((ToolTipTitleItem)buttonEdit.SuperTip.Items[0]).Text = "Sửa chức vụ";
            ((ToolTipItem)buttonEdit.SuperTip.Items[1]).Text = "Sửa thông tin chức vụ đang chọn";
            ((ToolTipTitleItem)buttonDelete.SuperTip.Items[0]).Text = "Xoá chức vụ";
            ((ToolTipItem)buttonDelete.SuperTip.Items[1]).Text = "Xoá chức vụ đang chọn\nNếu có nhân viên nào đang giữ chức vụ đó, tự động chuyển chức vụ của nhân viên thành \"Chưa có chức vụ\"";
            Cursor = Cursors.Default;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            panelMain.Controls.Add(controlTaskManager = new ControlTaskManager() { Dock = DockStyle.Fill });
            panelMain.Controls.Add(controlEmployeeManager = new ControlEmployeeManager() { Dock = DockStyle.Fill, Visible = false });
            panelMain.Controls.Add(controlRollManager = new ControlRollManager() { Dock = DockStyle.Fill, Visible = false });
            controlTaskManager.ViewWeek();
            Cursor = Cursors.Default;
        }

        private void ButtonLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SkipMessageBoxExitOrLogout = true;
            Close();
        }

        private void ButtonExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBoxArgs argsExitMessageBox = new XtraMessageBoxArgs(null, null, "Bạn có chắc muốn thoát?", "Thông báo", new DialogResult[] { DialogResult.Yes, DialogResult.No });
            argsExitMessageBox.Showing += Global.MessageBoxYesNo;
            DialogResult dialogResult = XtraMessageBox.Show(argsExitMessageBox);
            if (dialogResult == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                Global.isExit = true;
                SkipMessageBoxExitOrLogout = true;
                Close();
            }
        }

        private void ButtonAccountPage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FormAccount formAccount = new FormAccount();
            {
                formAccount.ShowDialog();
            }
            Cursor = Cursors.Default;
        }

        private void ButtonChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (FormChangePassword formChangePassword = new FormChangePassword(Global.account.Id))
            {
                formChangePassword.ShowDialog();
            }
            Cursor = Cursors.Default;
        }

        private void ButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (controlTaskManager.Visible)
                using (FormTask formTask = new FormTask())
                {
                    Global.isExecute = false;
                    formTask.ShowDialog();
                    if (Global.isExecute) controlTaskManager.LoadTask();
                }
            else if (controlEmployeeManager.Visible)
                using (FormEmployee formEmployee = new FormEmployee())
                {
                    Global.isExecute = false;
                    formEmployee.ShowDialog();
                    if (Global.isExecute) controlEmployeeManager.LoadEmployee();
                }
            else if (controlRollManager.Visible)
                using (FormRoll formRoll = new FormRoll())
                {
                    Global.isExecute = false;
                    formRoll.ShowDialog();
                    if (Global.isExecute) controlRollManager.LoadRoll();
                }
            Cursor = Cursors.Default;
        }

        private void ButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (controlTaskManager.Visible)
                using (FormTask formEditTask = new FormTask(controlTaskManager.GetFocusedTask()))
                {
                    Global.isExecute = false;
                    formEditTask.ShowDialog();
                    if (Global.isExecute) controlTaskManager.LoadTask();
                }
            else if (controlEmployeeManager.Visible)
                using (FormEmployee formEmployee = new FormEmployee(controlEmployeeManager.GetFocusedEmployee()))
                {
                    Global.isExecute = false;
                    formEmployee.ShowDialog();
                    if (Global.isExecute) controlEmployeeManager.LoadEmployee();
                }
            else if (controlRollManager.Visible)
                using (FormRoll formRoll = new FormRoll(controlRollManager.GetFocusedRoll()))
                {
                    Global.isExecute = false;
                    formRoll.ShowDialog();
                    if (Global.isExecute) controlRollManager.LoadRoll();
                }
            Cursor = Cursors.Default;
        }

        private void ButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (controlTaskManager.Visible)
            {
                controlTaskManager.DeleteTask();
            }
            else if (controlEmployeeManager.Visible)
            {
                controlEmployeeManager.DeleteEmployee();
            }
            else if (controlRollManager.Visible)
            {
                controlRollManager.DeleteRoll();
            }
            Cursor = Cursors.Default;
        }

        private void ButtonAddAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (FormAccount formAccount = new FormAccount(controlEmployeeManager.GetFocusedEmployee()))
            {
                Global.isExecute = false;
                formAccount.ShowDialog();
                if (Global.isExecute) controlEmployeeManager.LoadEmployee();
            }
            Cursor = Cursors.Default;
        }

        private void ButtonDeleteAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            controlEmployeeManager.DeleteAccount();
            Cursor = Cursors.Default;
        }

        private void ButtonResetPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            controlEmployeeManager.ResetPassword();
            Cursor = Cursors.Default;
        }

        private void ButtonExpandGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (controlTaskManager.Visible) controlTaskManager.ExpandGroup();
            else if (controlEmployeeManager.Visible) controlEmployeeManager.ExpandGroup();
            Cursor = Cursors.Default;
        }

        private void ButtonCollapseGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (controlTaskManager.Visible) controlTaskManager.CollapseGroup();
            else if (controlEmployeeManager.Visible) controlEmployeeManager.CollapseGroup();
            Cursor = Cursors.Default;
        }

        private void ButtonUnGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (controlTaskManager.Visible) controlTaskManager.UnGroup();
            else if (controlEmployeeManager.Visible) controlEmployeeManager.UnGroup();
            Cursor = Cursors.Default;
        }

        private void ButtonGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (controlTaskManager.Visible) controlTaskManager.Group();
            else if (controlEmployeeManager.Visible) controlEmployeeManager.Group();
            Cursor = Cursors.Default;
        }

        private void ButtonAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (FormAbout formAbout = new FormAbout())
            {
                formAbout.ShowDialog();
            }
            Cursor = Cursors.Default;
        }

        private void ButtonViewWeek_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            controlTaskManager.ViewWeek();
            Cursor = Cursors.Default;
        }

        private void ButtonViewMonth_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            controlTaskManager.ViewMonth();
            Cursor = Cursors.Default;

        }

        private void ButtonViewYear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            controlTaskManager.ViewYear();
            Cursor = Cursors.Default;
        }

        private void DateFrom_EditValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            repositoryTo.MinValue = ((DateTime)dateFrom.EditValue).AddDays(1);
            controlTaskManager.DateFrom();
            Cursor = Cursors.Default;
        }

        private void DateTo_EditValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            repositoryFrom.MaxValue = ((DateTime)dateTo.EditValue).AddDays(-1);
            controlTaskManager.DateTo();
            Cursor = Cursors.Default;
        }

        private void ButtonExportWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Export";
                saveFileDialog.FileName = "*.docx";
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.DefaultExt = "docx";
                saveFileDialog.Filter = "Microsoft Word files (*.docx)|*.docx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != null)
                {
                    Cursor = Cursors.WaitCursor;
                    Word doc = new Word((List<Task>)panelMain.Tag, (DateTime)dateFrom.EditValue, (DateTime)dateTo.EditValue, saveFileDialog.FileName);
                    Cursor = Cursors.Default;
                }
            }               
        }

        private void ButtonAđGroupRoll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (FromGroupRoll fromGroupRoll = new FromGroupRoll())
            {
                Global.isExecute = false;
                fromGroupRoll.ShowDialog();
                if (Global.isExecute) controlRollManager.LoadGroupRoll();
            }
            Cursor = Cursors.Default;
        }

        private void ButtonEditGroupRoll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (FromGroupRoll fromGroupRoll = new FromGroupRoll(controlRollManager.GetFocusedGroupRoll()))
            {
                Global.isExecute = false;
                fromGroupRoll.ShowDialog();
                if (Global.isExecute) controlRollManager.LoadGroupRoll();
            }
            Cursor = Cursors.Default;
        }

        private void ButtonDeleteGroupRoll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            controlRollManager.DeleteGroupRoll();
            Cursor = Cursors.Default;
        }
    }
}