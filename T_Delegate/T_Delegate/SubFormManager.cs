using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace T_Delegate
{
    class SubFormManager
    {
        static int nowSonCount = 0;
        
        public static void Create(Action<string> soncall)
        {
            SubForm subForm = new SubForm(++nowSonCount);
            subForm.momCallEvent += new SubForm.momCall(soncall);
            subForm.Show();
        }
    }
}
