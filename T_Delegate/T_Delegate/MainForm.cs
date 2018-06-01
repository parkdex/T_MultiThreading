using System;
using System.Windows.Forms;

namespace T_Delegate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sonsCall(string _sonCount)
        {
            this.txt_CallMonitor.Text = string.Format("{0} 번 폼이 나를 호출하였습니다", _sonCount);
        }

        private void btn_MakeSubForm_Click(object sender, EventArgs e)
        {
            SubForm subForm = new SubForm(SonCount.getSonCount());
            subForm.momCallEvent += new SubForm.momCall(sonsCall);
            subForm.Show();
        }
        
    }
}
