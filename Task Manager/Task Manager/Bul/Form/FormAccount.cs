using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Task_Manager.Bul.Class;
using Task_Manager.Dao;
using Task_Manager.Dto;

namespace Task_Manager.Bul.Form
{
    public partial class FormAccount : XtraForm
    {
        public FormAccount()
        {
            InitializeComponent();
            void FormClose(object sender, EventArgs e)
            {
                Close();
            }
            Account account =Global.account;
            buttonSubmit.Click += FormClose;
            textUsername.Text = account.Username;
            textId.Text = account.Id.ToString();
            textName.Text = account.Name;
            textRoll.Text = account.RollName;
            textPhone.Text = account.Phone;
            textEmail.Text = account.Email;
        }
        public FormAccount(Account account)
        {
            InitializeComponent();
            simpleLabelItem1.Text += " *";
            Name = "Cấp tài khoản";
            void AddAccount(object sender, EventArgs e)
            {
                string username = Regex.Replace(textUsername.Text.Trim(), " {2,}", " ").ToLower();
                if (username != "")
                {
                    Cursor = Cursors.WaitCursor;
                    if (DaoAccount.Instance.InsertAccount(account.Id, username) == 1)
                    {
                        Global.isExecute = true;
                        Close();
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Tên tài khoản đã được sử dụng", "Thông báo", new DialogResult[] { DialogResult.OK });
                        argsLoginMessageBox.Showing += Global.MessageBoxOK;
                        XtraMessageBox.Show(argsLoginMessageBox);
                        textUsername.Text = "";
                    }
                }
                else
                {
                    XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Vui lòng điền đầy đủ thông tin", "Thông báo", new DialogResult[] { DialogResult.OK });
                    argsLoginMessageBox.Showing += Global.MessageBoxOK;
                    XtraMessageBox.Show(argsLoginMessageBox);
                }

            }
            buttonSubmit.Text = "Cấp tài khoản";
            buttonSubmit.Click += AddAccount;
            textUsername.ReadOnly = false;
            textId.Text = account.Id.ToString();
            textName.Text = account.Name;
            textRoll.Text = account.RollName;
            textPhone.Text = account.Phone;
            textEmail.Text = account.Email;
        }
    }
}