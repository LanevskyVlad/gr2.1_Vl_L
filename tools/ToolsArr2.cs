using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsArr2
    {
        private int[,] Temp;
        private bool[,] BoolTemp;
        public int[,] Arr2 { get; set; }
        public ToolsArr2(int[,] arr2)
        {
            Arr2 = arr2;
        }
        private delegate int recursion(int set, int row, int column);
        private int Step(recursion F, int set, int row, int column)
        {
            int sum = 0;
            if (row != 0)
                sum+= F(set, row - 1, column);
            if (row != Arr2.GetLength(0) - 1)
                sum += F(set, row + 1, column);
            if (column != 0)
                sum += F(set, row, column - 1);
            if (column != Arr2.GetLength(1)-1)
                sum += F(set, row, column + 1);
            return sum;
        }
        private int SearchCount(int set, int row, int column)
        {
            if (BoolTemp[row, column] || Arr2[row, column] != set)
                return 0;
            BoolTemp[row, column] = true;
            return Step(SearchCount, set, row, column) + 1;
        }
        private int SetCount(int set, int row, int column)
        {
            if (!BoolTemp[row, column])
                return 0;
            BoolTemp[row, column] = false;
            Temp[row, column] = set;
            return Step(SetCount, set, row, column);
        }

        public int[,] GetCount()
        {
            Temp = new int[Arr2.GetLength(0), Arr2.GetLength(1)];
            BoolTemp = new bool[Arr2.GetLength(0), Arr2.GetLength(1)];
            int count;
            for (int i = 0; i < Arr2.GetLength(0); i++)
            {
                for (int j = 0; j < Arr2.GetLength(1); j++)
                {
                    if (Temp[i, j] == 0)
                    {
                        BoolTemp = new bool[Arr2.GetLength(0), Arr2.GetLength(1)];
                        count = SearchCount(Arr2[i, j], i, j) - 1;
                        SetCount(count, i, j);
                    }
                }
            }
            return Temp;
        }
        public List<Cell> GetCels()
        {
            List<Cell> list = new List<Cell>();
            for (int i = 0; i < Arr2.GetLength(0); i++)
            {
                for (int j = 0; j < Arr2.GetLength(1); j++)
                {
                    if (Arr2[i, j] % 2 == 0 && (i + j) % 2 == 1)
                        list.Add(new Cell(i, j));
                }
            }
            return list;
        }
    }
}
