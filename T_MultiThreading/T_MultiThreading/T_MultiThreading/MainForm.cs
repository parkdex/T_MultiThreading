using System;
using System.Collections.Generic;
using System.Windows.Forms;

using T_MultiThreading.Classes;

namespace T_MultiThreading
{
    public partial class MainForm : Form
    {
        private SubForm[] subFormArray = null;
        private Queue<int>[] queArray = null;

        // Action, Func, Predicate
        public Action action = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // delegate
            // 어떤 메소드를 직접 호출하지 않고, 메소드를 실행할 수 있는 방법 

            // 왜? 굳이 호출하지 않고 뭔가 우회해서 실행해야 하는가?
            // 메소드를 변수처럼 다뤄야 할 필요가 생김, 여기서 목적이 생김
            // 이 메소드가 언젠가(비동기?) 호출이 되기를 기대하는 것

            action = ActionTest;

            //int a = 0;
            //float b = 1.1;
            //SubForm form1 = new SubForm();
            //xxx method1 = xxx;

            Button button = new Button();
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // 버튼 클릭되면 룰루랄라 구현
        }

        private void ActionTest()
        {
            MessageBox.Show("Action!");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int sonCount = int.Parse(textBox1.Text);
            queArray = new Queue<int>[sonCount];
            subFormArray = new SubForm[sonCount];

            RandNumMaker randMaker = new RandNumMaker(sonCount, queArray);   
            make_subForm(sonCount);

            action();
        }

        private void make_subForm(int _subFormCount)
        {
            for (int i = 0; i < _subFormCount; i++)
            {
                SubForm subForm = new SubForm(i, queArray[i]);
                subForm.Text = i.ToString();
                setSubFormSize(subForm, _subFormCount);
                
                subForm.TopLevel = false;

                this.flowLayoutPanel1.Controls.Add(subForm);
                subForm.Show();
            }
        }

        private void setSubFormSize(Form _form, int _subFormCount)
        {
            int widthBorderSize = 10;
            int heightBorderSize = 30;

            _form.Width = _subFormCount % 2 == 0 ? this.flowLayoutPanel1.Width / (_subFormCount / 2) + widthBorderSize :
                                                   this.flowLayoutPanel1.Width / (_subFormCount / 2 + 1) + widthBorderSize;

            _form.Height = this.flowLayoutPanel1.Height / 2 + heightBorderSize;
        }
        
    }
}
