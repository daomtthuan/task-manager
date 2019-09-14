using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Task_Manager.Dao;
using Task_Manager.Dto;
using Task_Manager.Bul.Class;
using System.Text.RegularExpressions;
using System.Threading;
using DevExpress.Utils;

namespace Task_Manager.Bul.Form
{
    public partial class FormEmployee : DevExpress.XtraEditors.XtraForm
    {
     
        public FormEmployee()
        {
            InitializeComponent();
            Name = "Thêm nhân viên";

            void LoadForm(object sender, EventArgs e)
            {
                Cursor = Cursors.WaitCursor;
                LoadData(DaoRoll.Instance.GetRoll());
                Cursor = Cursors.Default;
            }

            void AddEmployee(object sender, EventArgs e)
            {
                string name = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Regex.Replace(textName.Text.Trim(), " {2,}", " ").ToLower());
                object rollId = lookupRoll.EditValue;
                string phone = Regex.Replace(textPhone.Text.Trim(), " {2,}", " ");
                string email = Regex.Replace(textEmail.Text.Trim(), " {2,}", " ").ToLower();
                if (name != "" && rollId != null)
                {
                    Cursor = Cursors.WaitCursor;
                    Global.isExecute = true;
                    DaoEmployee.Instance.InsertEmployee(name, (int)rollId, phone, email);
                    Global.isExecute = true;
                    textName.Text = "";
                    lookupRoll.EditValue = null;
                    textPhone.Text = "";
                    textEmail.Text = "";
                    Cursor = Cursors.Default;
                }
                else
                {
                    XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Vui lòng điền đầy đủ thông tin", "Thông báo", new DialogResult[] { DialogResult.OK });
                    argsLoginMessageBox.Showing += Global.MessageBoxOK;
                    XtraMessageBox.Show(argsLoginMessageBox);
                }
            }

            Load += LoadForm;
            buttonSubmit.Click += AddEmployee;
        }

        public FormEmployee(Account employee)
        {
            InitializeComponent();
            Name = "Cập nhật nhân viên";

            void LoadForm(object sender, EventArgs e)
            {
                Cursor = Cursors.WaitCursor;
                LoadData(DaoRoll.Instance.GetRoll());
                textName.Text = employee.Name;
                lookupRoll.EditValue = employee.RollId;
                textPhone.Text = employee.Phone;
                textEmail.Text = employee.Email;
                Cursor = Cursors.Default;
            }

            void EditEmployee(object sender, EventArgs e)
            {
                string name = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Regex.Replace(textName.Text.Trim(), " {2,}", " ").ToLower());
                object rollId = lookupRoll.EditValue;
                string phone = Regex.Replace(textPhone.Text.Trim(), " {2,}", " ");
                string email = Regex.Replace(textEmail.Text.Trim(), " {2,}", " ").ToLower();
                if (name != "" && rollId != null)
                {
                    Cursor = Cursors.WaitCursor;
                    DaoEmployee.Instance.UpdateEmployee(employee.Id, name, (int)rollId, phone, email);
                    Global.isExecute = true;
                    if (Global.account.Id == employee.Id) DaoAccount.Instance.Refresh();
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
            buttonSubmit.Click += EditEmployee;
        }

        private void LoadData(List<Roll> rolls)
        {
            lookupRoll.Properties.DataSource = rolls;
            lookupRoll.Properties.PopulateColumns();
            lookupRoll.Properties.DisplayMember = "Name";
            lookupRoll.Properties.ValueMember = "Id";
            lookupRoll.Properties.Columns["Id"].Visible = false;
            lookupRoll.Properties.Columns["Level"].Caption = "Cấp bậc";
            lookupRoll.Properties.Columns["Level"].Width = 50;
            lookupRoll.Properties.Columns["Level"].Alignment = HorzAlignment.Near;
            lookupRoll.Properties.Columns["Level"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            lookupRoll.Properties.Columns["Name"].Caption = "Chức vụ";
            if (rolls.Count <= 20) lookupRoll.Properties.DropDownRows = rolls.Count;
        }
    }
}