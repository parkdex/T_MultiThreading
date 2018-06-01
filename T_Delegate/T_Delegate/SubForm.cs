using System;
using System.Windows.Forms;

namespace T_Delegate
{
    public partial class SubForm : Form
    {
        public delegate void momCall(string _sonCount);
        public event momCall momCallEvent;

        public SubForm(int _nowSonCount)
        {
            InitializeComponent();
            this.Text = _nowSonCount.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Tag)
            {
                case "CALL":
                    this.momCallEvent(this.Text);
                    break;

                case "MAKE":
                    SubForm subForm = new SubForm(SonCount.getSonCount());
                    subForm.momCallEvent += new SubForm.momCall(momCallEvent);
                    subForm.Show();
                    break;
            }
        }
    }
}
