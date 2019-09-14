using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Task_Manager.Dao;
using Task_Manager.Bul.Class;
using Task_Manager.Dto;

namespace Task_Manager.Bul.Form
{
    public partial class FromLogin : XtraForm
    {
        public FromLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" || textPassword.Text == "")
            {
                XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Vui lòng điền tên đăng nhập và mật khẩu", "Thông báo", new DialogResult[] { DialogResult.OK });
                argsLoginMessageBox.Showing += Global.MessageBoxOK;
                XtraMessageBox.Show(argsLoginMessageBox);
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                Account account = DaoAccount.Instance.Login(textUsername.Text, textPassword.Text);
                Cursor = Cursors.Default;

                if (account == null)
                {
                    XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", new DialogResult[] { DialogResult.OK });
                    argsLoginMessageBox.Showing += Global.MessageBoxOK;
                    XtraMessageBox.Show(argsLoginMessageBox);
                }
                else
                {
                    Cursor = Cursors.WaitCursor;
                    Global.isExit = false;
                    Global.account = account;
                    using (FormMain formMain = new FormMain())
                    {
                        Cursor = Cursors.Default;
                        Hide();
                        formMain.ShowDialog();
                        if (Global.isExit) Application.Exit();
                        else
                        {
                            textPassword.Text = "";
                            Show();
                        }
                    }
                }
            }
        }
    }
}