using DevExpress.XtraEditors;
using Task_Manager.Dto;

namespace Task_Manager.Bul.Class
{
    public static class Global
    {
        public static bool isExecute;
        public static bool isExit;
        public static Account account;

        public static void MessageBoxOK(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Controls[0].Text = "Xác nhận";
            e.Form.Controls[0].Width = 120;
            e.Form.Controls[0].Height = 30;
        }

        public static void MessageBoxYesNo(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Controls[0].Text = "Đồng ý";
            e.Form.Controls[1].Text = "Huỷ bỏ";
            e.Form.Controls[0].Width = 120;
            e.Form.Controls[1].Width = 120;
            e.Form.Controls[0].Height = 30;
            e.Form.Controls[1].Height = 30;
            e.Form.CancelButton = e.Buttons[System.Windows.Forms.DialogResult.No];
        }

        public static void MessageBoxExitOrLogout(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Controls[0].Text = "Thoát";
            e.Form.Controls[1].Text = "Huỷ bỏ";
            e.Form.Controls[2].Text = "Đăng xuất";
            e.Form.Controls[0].Width = 120;
            e.Form.Controls[0].Height = 30;
            e.Form.Controls[1].Width = 120;
            e.Form.Controls[1].Height = 30;
            e.Form.Controls[2].Width = 120;
            e.Form.Controls[2].Height = 30;
            e.Form.CancelButton = e.Buttons[System.Windows.Forms.DialogResult.No];
        }
    }
}
