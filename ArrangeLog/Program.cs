using System;
using System.Collections.Generic;

//using System.Linq;
using System.Text;

//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrangeLog
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            JudgeTime judgeTime = new JudgeTime();

            judgeTime.JudgeLog();
            //MessageBox.Show(judgeTime.JudgeLog().ToString());

            //while ("q" != Console.ReadLine()) ;
        }
    }
}