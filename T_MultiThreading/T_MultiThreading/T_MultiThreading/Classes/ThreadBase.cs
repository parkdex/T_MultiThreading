using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace T_MultiThreading.Classes
{
    class ThreadBase
    {
        private Thread workThread = null;
        private bool threadState = false;

        public ThreadBase()
        {
            
        }

        public void ThreadStart()
        {
            if (workThread == null)
            {
                workThread = new Thread(workMethod);
                workThread.IsBackground = true;
                threadState = true;
                workThread.Start();
            }
        }

        private void workMethod()
        {
            while (threadState)
            {

            }
        }

        public void ThreadStop()
        {
            try
            {
                if (workThread != null)
                {
                    if (workThread.IsAlive)
                    {
                        threadState = false;
                        workThread.Abort();
                    }
                    workThread = null;
                }
            }
            catch
            { }
        }

    }
}
