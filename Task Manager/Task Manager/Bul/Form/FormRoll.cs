using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Task_Manager.Bul.Class;
using Task_Manager.Dao;
using Task_Manager.Dto;

namespace Task_Manager.Bul.Form
{
    public partial class FormRoll : DevExpress.XtraEditors.XtraForm
    {
        public FormRoll()
        {
            InitializeComponent();
            void AddRoll(object sender, EventArgs e)
            {
                if (textName.Text != "" && textLevel.Text != "")
                {
                    Cursor = Cursors.WaitCursor;
                    string name = Regex.Replace(textName.Text.Trim(), " {2,}", " ");
                    name = name[0].ToString().ToUpper() + name.Substring(1);
                    bool result = DaoRoll.Instance.InsertRoll(name,  Int32.Parse(textLevel.Text)) == 1;
                    Cursor = Cursors.Default;
                    if (result)
                    {
                        Global.isExecute = true;
                        textName.Text = "";
                        textLevel.Text = "";
                    }
                    else
                    {
                        XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Chức vụ đã tồn tại", "Thông báo", new DialogResult[] { DialogResult.OK });
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
            buttonSubmit.Click += AddRoll;
        }

        public FormRoll(Roll roll)
        {
            InitializeComponent();
            textName.Text = roll.Name;
            textLevel.Text = roll.Level.ToString();
            Name = "Cập nhật chức vụ";            
            void EditRoll(object sender, EventArgs e)
            {
                if (textName.Text != "" && textLevel.EditValue != null)
                {
                    Cursor = Cursors.WaitCursor;
                    string name = Regex.Replace(textName.Text.Trim(), " {2,}", " ");
                    name = name[0].ToString().ToUpper() + name.Substring(1);
                    bool result = DaoRoll.Instance.UpdateRoll(roll.Id, name, Int32.Parse(textLevel.Text)) == 1;
                    Cursor = Cursors.Default;
                    if (result)
                    {
                        Cursor = Cursors.WaitCursor;
                        Global.isExecute = true;
                        if (Global.account.RollId == roll.Id) DaoAccount.Instance.Refresh();
                        Close();
                    }
                    else
                    {
                        XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Chức vụ đã tồn tại", "Thông báo", new DialogResult[] { DialogResult.OK });
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
            buttonSubmit.Text = "Cập nhật";
            buttonSubmit.Click += EditRoll;
        }
    }
}