using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Task_Manager.Dto;
using Task_Manager.Dao;
using DevExpress.Utils;
using Task_Manager.Bul.Class;
using System.Text.RegularExpressions;

namespace Task_Manager.Bul.Form
{
    public partial class FormTask : DevExpress.XtraEditors.XtraForm
    {
        public FormTask()
        {
            InitializeComponent();

            void AddTask(object sender, EventArgs e)
            {
                object employeeId = lookupObject.EditValue;
                object time = dateDateTime.EditValue;
                string location = Regex.Replace(textLocation.Text.Trim(), " {2,}", " ");
                if (location != "") location = location[0].ToString().ToUpper() + location.Substring(1);
                string content = Regex.Replace(textContent.Text.Trim(), " {2,}", " ");
                if (content != "") content = content[0].ToString().ToUpper() + content.Substring(1);
                string note = Regex.Replace(textNote.Text.Trim(), " {2,}", " ");
                if (note != "") note = note[0].ToString().ToUpper() + note.Substring(1);

                if (employeeId != null && time != null)
                {
                    if (DateTime.Compare((DateTime)dateDateTime.EditValue, DateTime.Now.StartOfWeek(DayOfWeek.Monday)) < 0)
                    {
                        XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Bạn có chắc muốn thêm lịch trình cho tuần đã qua", "Thông báo", new DialogResult[] { DialogResult.Yes, DialogResult.No });
                        argsLoginMessageBox.Showing += Global.MessageBoxYesNo;
                        if (XtraMessageBox.Show(argsLoginMessageBox) == DialogResult.No)
                            return;
                    }
                    Cursor = Cursors.WaitCursor;
                    DaoTask.Instance.InsertTask((int)employeeId, (DateTime)time, location, content, note);
                    Global.isExecute = true;
                    lookupObject.EditValue = null;
                    dateDateTime.EditValue = null;
                    textLocation.Text = "";
                    textContent.Text = "";
                    textNote.Text = "";
                    Cursor = Cursors.Default;
                }
                else
                {
                    XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Vui lòng điền đầy đủ thông tin", "Thông báo", new DialogResult[] { DialogResult.OK });
                    argsLoginMessageBox.Showing += Global.MessageBoxOK;
                    XtraMessageBox.Show(argsLoginMessageBox);
                }
            }

            Load += LoadEmployee;
            buttonSubmit.Click += AddTask;
        }

        public FormTask(Task task)
        {
            InitializeComponent();
            Name = "Cập nhật lịch trình";
            void LoadForm(object sender, EventArgs e)
            {
                if (task.RollId != "")
                    LoadEmployee(sender, e);
                else
                {
                    radioIsEmployee.EditValue = false;
                }
                Cursor = Cursors.WaitCursor;
                lookupObject.EditValue = task.ObjectId;
                dateDateTime.EditValue = task.Time;
                textLocation.Text = task.Location;
                textContent.Text = task.Content;
                textNote.Text = task.Note;
                Cursor = Cursors.Default;
            }

            void EditTask(object sender, System.EventArgs e)
            {
                object employeeId = lookupObject.EditValue;
                object time = dateDateTime.EditValue;
                string location = Regex.Replace(textLocation.Text.Trim(), " {2,}", " ");
                if (location != "") location = location[0].ToString().ToUpper() + location.Substring(1);
                string content = Regex.Replace(textContent.Text.Trim(), " {2,}", " ");
                if (content != "") content = content[0].ToString().ToUpper() + content.Substring(1);
                string note = Regex.Replace(textNote.Text.Trim(), " {2,}", " ");
                if (note != "") note = note[0].ToString().ToUpper() + note.Substring(1);
                if (employeeId != null && lookupObject.Text != "" && time != null)
                {
                    Cursor = Cursors.WaitCursor;
                    DaoTask.Instance.UpdateTask(task.Id, (int)employeeId, (DateTime)time, location, content, note);
                    Global.isExecute = true;
                    Close();
                }
                else
                {
                    XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Vui lòng điền đầy đủ thông tin", "Thông báo", new DialogResult[] { DialogResult.OK });
                    argsLoginMessageBox.Showing += Global.MessageBoxOK;
                    XtraMessageBox.Show(argsLoginMessageBox);
                }
            }

            buttonSubmit.Text = "Cập nhật";
            Load += LoadForm;
            buttonSubmit.Click += EditTask;
        }

        private void LoadEmployee(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            lookupObject.Properties.Columns.Clear();
            List<Employee> employees = DaoEmployee.Instance.GetEmployee();
            lookupObject.Properties.DataSource = employees;
            lookupObject.Properties.PopulateColumns();
            lookupObject.Properties.DisplayMember = "Name";
            lookupObject.Properties.ValueMember = "Id";
            lookupObject.Properties.Columns["Id"].Width = 50;
            lookupObject.Properties.Columns["Id"].Caption = "Mã số";
            lookupObject.Properties.Columns["Id"].Alignment = HorzAlignment.Near;
            lookupObject.Properties.Columns["Name"].Caption = "Họ tên";
            lookupObject.Properties.Columns["RollId"].Visible = false;
            lookupObject.Properties.Columns["RollName"].Caption = "Chức vụ";
            lookupObject.Properties.Columns["RollLevel"].Caption = "Cấp bậc";
            lookupObject.Properties.Columns["RollLevel"].Alignment = HorzAlignment.Near;
            lookupObject.Properties.Columns["RollLevel"].Width = 50;
            lookupObject.Properties.Columns["Phone"].Caption = "Số điện thoại";
            lookupObject.Properties.Columns["Email"].Caption = "Email";
            if (employees.Count <= 20) lookupObject.Properties.DropDownRows = employees.Count;
            lookupObject.Properties.PopupWidth = 900;
            simpleLabelItem1.Text = "Nhân viên *";
            Cursor = Cursors.Default;
        }

        private void LoadGroupRoll(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            lookupObject.Properties.Columns.Clear();
            List<GroupRoll> groups = DaoGroupRoll.Instance.GetGroupRoll();
            lookupObject.Properties.DataSource = groups;
            lookupObject.Properties.PopulateColumns();
            lookupObject.Properties.DisplayMember = "Name";
            lookupObject.Properties.ValueMember = "Id";
            lookupObject.Properties.Columns["Id"].Visible = false;
            lookupObject.Properties.Columns["Name"].Caption = "Tên nhóm";
            if (groups.Count <= 20) lookupObject.Properties.DropDownRows = groups.Count;
            lookupObject.Properties.PopupWidth = 500;
            simpleLabelItem1.Text = "Nhóm chức vụ *";
            Cursor = Cursors.Default;
        }

        private void RadioIsEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Boolean)radioIsEmployee.EditValue)
                LoadEmployee(sender, e);
            else LoadGroupRoll(sender, e);
        }
    }
}