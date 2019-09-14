using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Task_Manager.Bul.Class;
using Task_Manager.Dao;

namespace Task_Manager.Bul.Form
{
    public partial class FormChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public FormChangePassword(int EmployeeId)
        {
            InitializeComponent();
            Tag = EmployeeId;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (textOldPassword.Text != "" && textNewPassword.Text != "" && textRePassword.Text != "")
            {
                if (textNewPassword.Text == textRePassword.Text)
                {
                    Cursor = Cursors.WaitCursor;
                    if (DaoAccount.Instance.ChangePassword((int)Tag, textOldPassword.Text, textNewPassword.Text) == 1) Close();
                    else
                    {
                        Cursor = Cursors.Default;
                        XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Mật khẩu không đúng", "Thông báo", new DialogResult[] { DialogResult.OK });
                        argsLoginMessageBox.Showing += Global.MessageBoxOK;
                        XtraMessageBox.Show(argsLoginMessageBox);
                    }
                }
                else
                {
                    XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Mật khẩu nhập lại không khớp", "Thông báo", new DialogResult[] { DialogResult.OK });
                    argsLoginMessageBox.Showing += Global.MessageBoxOK;
                    XtraMessageBox.Show(argsLoginMessageBox);
                }
            }
            else
            {
                XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Vui lòng điền đầy đủ thông tin", "Thông báo", new DialogResult[] { DialogResult.OK });
                argsLoginMessageBox.Showing += Global.MessageBoxOK;
                XtraMessageBox.Show(argsLoginMessageBox);
            }
        }
    }
}