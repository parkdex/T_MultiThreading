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

        public SubForm(int _subFormName, Queue<int> _queue)
        {
            InitializeComponent();
            subFormName = _subFormName.ToString();
            chartSetting();

            queue = _queue;
            writeQue = new Queue<int>();
            WriteLog writeLog = new WriteLog(subFormName, writeQue);

            timer1.Start();
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
