using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Task_Manager.Bul.Class;
using Task_Manager.Dao;
using Task_Manager.Dto;

namespace Task_Manager.Bul.Form
{
    public partial class FromGroupRoll : XtraForm
    {
        public FromGroupRoll()
        {
            InitializeComponent();
            void AddGroupRoll(object sender, EventArgs e)
            {
                if (textName.Text != "")
                {                    
                    Cursor = Cursors.WaitCursor;
                    string name = Regex.Replace(textName.Text.Trim(), " {2,}", " ");
                    name = name[0].ToString().ToUpper() + name.Substring(1);
                    bool result = DaoGroupRoll.Instance.InsertGroupRoll(name) == 1;
                    Cursor = Cursors.Default;
                    if (result)
                    {
                        Global.isExecute = true;
                        textName.Text = "";
                    }
                    else
                    {
                        XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Nhóm chức vụ đã tồn tại", "Thông báo", new DialogResult[] { DialogResult.OK });
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

            buttonSubmit.Click += AddGroupRoll;
        }

        public FromGroupRoll(GroupRoll group)
        {
            InitializeComponent();
            textName.Text = group.Name;
            Name = "Cập nhật nhóm chức vụ";
            void EditGroupRoll(object sender, EventArgs e)
            {
                if (textName.Text != "")
                {
                    Cursor = Cursors.WaitCursor;
                    string name = Regex.Replace(textName.Text.Trim(), " {2,}", " ");
                    name = name[0].ToString().ToUpper() + name.Substring(1);
                    bool result = DaoGroupRoll.Instance.UpdateGroupRoll(group.Id, name) == 1;
                    Cursor = Cursors.Default;
                    if (result)
                    {
                        Global.isExecute = true;
                        Close();
                    }
                    else
                    {
                        XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Nhóm chức vụ đã tồn tại", "Thông báo", new DialogResult[] { DialogResult.OK });
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
            buttonSubmit.Click += EditGroupRoll;
        }
    }
}