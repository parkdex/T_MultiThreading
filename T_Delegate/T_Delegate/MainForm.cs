using System;
using System.Windows.Forms;

namespace T_Delegate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Action action = () => { };
            Action<int> action2 = val => { };
            Action<int, string> action3 = (val1, val2) => { };
            Func<string, bool> action4 = (val3) => { return true; };
            bool result = action4("true");
        }
        
        private void btn_MakeSubForm_Click(object sender, EventArgs e)
        {
            SubFormManager.Create(sonCount => txt_CallMonitor.Text = $"{sonCount}번 폼이 나를 호출하였습니다");
        }
    }
}
