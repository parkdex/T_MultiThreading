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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int sonCount = int.Parse(textBox1.Text);
            queArray = new Queue<int>[sonCount];
            subFormArray = new SubForm[sonCount];

            RandNumMaker randMaker = new RandNumMaker(sonCount, queArray);   
            make_subForm(sonCount);
        }

        private void chartClickEvent(string _subFormText)
        {
            MessageBox.Show(_subFormText + " 차트를 클릭하였습니다");
        }

        private void make_subForm(int _subFormCount)
        {
            for (int i = 0; i < _subFormCount; i++)
            {
                SubForm subForm = new SubForm(i, queArray[i]);
                subForm.action += new Action<string>(chartClickEvent);
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
