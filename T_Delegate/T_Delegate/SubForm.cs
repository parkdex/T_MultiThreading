using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace T_Delegate
{
    enum FormType
    {
        Mon,
        Son
    }
    public partial class SubForm : Form
    {
        public delegate void momCall(string _sonCount);
        public event momCall momCallEvent;

        public List<Action<object, EventArgs>> buttonEvents = new List<Action<object, EventArgs>>();        

        public SubForm(int _nowSonCount)
        {
            buttonEvents.Add((sender, e) => momCallEvent(this.Text));
            buttonEvents.Add((sender, e) => SubFormManager.Create(new Action<string>(momCallEvent)));

            InitializeComponent();

            this.Text = _nowSonCount.ToString();
        }
    }
}
