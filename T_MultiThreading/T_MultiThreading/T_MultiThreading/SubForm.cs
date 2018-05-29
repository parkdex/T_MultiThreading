using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using T_MultiThreading.Classes;

namespace T_MultiThreading
{
    public partial class SubForm : Form
    {
        private string subFormName = string.Empty;
        private Queue<int> queue = null;
        private Queue<int> writeQue = null;

        // JongFeel멘토님
        // delegate (완성된 델리게이트 종류 : Action, Func, Predicate
        // 어떤 메소드를 직접 호출하지 않고, 메소드를 실행할 수 있는 방법 

        // 왜? 굳이 호출하지 않고 뭔가 우회해서 실행해야 하는가?
        // 메소드를 변수처럼 다뤄야 할 필요가 생김, 여기서 목적이 생김
        // 이 메소드가 언젠가(비동기?) 호출이 되기를 기대하는 것
        public event Action<string> action = null;

        public SubForm(int _subFormName, Queue<int> _queue)
        {
            InitializeComponent();
            chartSetting();

            subFormName = _subFormName.ToString(); 
            queue = _queue;

            writeQue = new Queue<int>();
            WriteLog writeLog = new WriteLog(subFormName, writeQue);
            timer1.Start();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            action(this.Text);
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            DoubleBuffered = true;
            typeof(Chart).InvokeMember("DoubleBuffered",
                                       BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                                       null, this.chart1, new object[] { true });
        }

        private void chartSetting()
        {
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            this.chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            this.chart1.Series[0].IsVisibleInLegend = false;            
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_ReadQueCount.Text = queue.Count.ToString();
            lbl_WriteQueCount.Text = this.writeQue.Count.ToString();
            lbl_ListBoxCount.Text = this.listBox1.Items.Count.ToString();            

            if (queue.Count != 0)
            {                
                int dequeue = queue.Dequeue();
                writeQue.Enqueue(dequeue);
                drawControls(dequeue);
            }            
        }

        private void drawControls(int _value)
        {
            this.listBox1.Items.Insert(0, _value);
            this.chart1.Series[0].Points.AddY(_value);
        }

        
    }
}
