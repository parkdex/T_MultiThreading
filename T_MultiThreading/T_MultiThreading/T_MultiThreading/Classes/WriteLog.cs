using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;
using System.Windows.Forms;

namespace T_MultiThreading.Classes
{
    class WriteLog
    {
        private string subFormName = string.Empty;
        private Queue<int> writeQue = null;
        private System.Timers.Timer timer = null;

        private string filePath = string.Empty;

        public WriteLog(string _subFormName, Queue<int> _writeQue)
        {
            subFormName = _subFormName;
            writeQue = _writeQue;

            filePath = string.Format(@"{0}\{1}.txt", Application.StartupPath, subFormName);

            timer = new System.Timers.Timer();
            timer.Interval = 5000;
            timer.Elapsed += new ElapsedEventHandler(timerTick);
            timer.Start();
        }

        private void timerTick(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (writeQue.Count != 0)
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Append))
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        for (int i = 0; i < writeQue.Count; i++)
                        {
                            streamWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " : " + writeQue.Dequeue());
                        }
                    }
                }
            }
            catch
            { }
        }
    }
}
