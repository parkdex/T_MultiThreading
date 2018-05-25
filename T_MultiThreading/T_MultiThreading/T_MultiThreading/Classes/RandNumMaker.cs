using System;
using System.Collections.Generic;

using System.Timers;

namespace T_MultiThreading.Classes
{
    class RandNumMaker
    {
        private System.Timers.Timer timer = null;

        private int[] randNumArray = null;
        private Queue<int>[] queArray = null;
        private Random random = null;

        public RandNumMaker(int _randCount, Queue<int>[] _queArray)
        {
            randNumArray = new int[_randCount];
            queArray = _queArray;
            for (int i = 0; i < queArray.Length; i++)
            {
                queArray[i] = new Queue<int>();
            }

            random = new Random();

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(timerTick);
            timer.Start();
        }

        private void timerTick(object sender, ElapsedEventArgs e)
        {
            for (int i = 0; i < randNumArray.Length; i++)
            {
                int randNum = random.Next(-500, 500);

                randNumArray[i] = randNum;
                queArray[i].Enqueue(randNum);
            }
        }

    }
}
