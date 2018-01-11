using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsConsole;
using tools;

namespace _9._18_console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Task();
            }
        }

        private static void Task()
        {
            int[,] Arr2 = ToolsConsoleArr2.ReadArr2();
            ToolsArr2 toolsArr2 = new ToolsArr2(Arr2);
            int[,] OutArr2 = toolsArr2.GetCount();
            ToolsConsoleArr2.OutputArr2(OutArr2);
        }
    }
}
