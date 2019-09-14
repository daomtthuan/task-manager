namespace Task_Manager.Bul.Form
{
    public partial class FormAbout : DevExpress.XtraEditors.XtraForm
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void HyperlinkLabelControl2_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/dao.mt.thuan");
        }

        private void HyperlinkLabelControl1_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://daomtthuan.github.io");
        }
    }
}