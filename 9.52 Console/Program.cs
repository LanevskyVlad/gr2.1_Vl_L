using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsConsole;
using tools;

namespace _9._49_Console
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
            List<Cell> list = toolsArr2.GetCels();
            ToolsConsoleArr2.OutputStr(ConvertList.ListToStr(list));
        }
    }
}
