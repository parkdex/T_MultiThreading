using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T_Delegate
{
    static class SonCount
    {
        static int nowSonCount = 0;

        public static int getSonCount()
        {
            nowSonCount++;
            return nowSonCount;
        }
    }
}
