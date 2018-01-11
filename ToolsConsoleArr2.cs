using System;
using System.IO;
using System.Text;
using tools;

namespace ToolsConsole
{
    public class ToolsConsoleArr2
    {
        public static int[,] ReadArr2()
        {
            Console.Write("Считать двумерный массив из файла ? (y/n)");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                if ((key.KeyChar == 'y') || (key.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.Write("введите имя файла:");
                        try
                        {
                            return FileReadArr2(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((key.KeyChar == 'n') || (key.KeyChar == 'N'))
                {
                    while (true)
                    {
                        Console.WriteLine("введите двумерынй массив ");
                        try
                        {
                            return ConsoleReadArr2();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }
        static int[,] ConsoleReadArr2()
        {
            StringBuilder str = new StringBuilder();
            string line;
            line = Console.ReadLine();
            while (line != "")
            {
                str.AppendLine(line);
                line = Console.ReadLine();
            }
            return ConvertArr2.StrToArr2(str.ToString());
        }
        static int[,] FileReadArr2(string Path)
        {
            FileArr2 file = new FileArr2(Path);
            return file.ReadArr2();
        }
        static void FileWriteArr2(int[,] Arr2, string Path)
        {
            FileArr2 file = new FileArr2(Path);
            file.WriteArr2(Arr2);
        }
        static void ConsoleWriteArr2(int[,] Arr2)
        {
            Console.WriteLine(ConvertArr2.Arr2ToStr(Arr2));
        }
        public static void OutputArr2(int[,] Arr2)
        {
            Console.Write("записать двумерынй массив в файл ? (y/n)");
            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.Write("введите имя файла:");
                        try
                        {
                            FileWriteArr2(Arr2, Console.ReadLine());
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    ConsoleWriteArr2(Arr2);
                    Console.ReadKey();
                    break;
                }
            }
        }
        public static void OutputStr(int s)
        {
            Console.WriteLine("записать ответ в файл ? (y/n)");
            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.WriteLine("введите имя файла:");
                        try
                        {
                            File.WriteAllText(Console.ReadLine(), s.ToString());
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
