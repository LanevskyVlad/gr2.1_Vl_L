using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tools
{
    public class FileArr2
    {
        public string Path { get; set; }
        public FileArr2(string path)
        {
            this.Path = path;
        }
        public void WriteArr2(int[,] Arr2)
        {
            try
            {
                File.WriteAllText(Path, ConvertArr2.Arr2ToStr(Arr2));
            }
            catch (Exception)
            {
                throw new Exception("ошибка записи");
            }
        }
        public int[,] ReadArr2()
        {
            if (Path == null)
                throw new Exception("ошибка чтения");
            return ConvertArr2.StrToArr2(File.ReadAllText(Path));
        }
    }
}
