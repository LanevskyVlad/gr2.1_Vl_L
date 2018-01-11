using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsArr
    {
        public int[] Arr { get; set; }
        public ToolsArr(int[] arr)
        {
            Arr = arr;
        }
        private int SeriesCount()
        {
            int count = 1;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] != Arr[i - 1])
                    count++;
            }
            return count;
        }
        private int[] ChangeElements(bool Remove)
        {
            int[] ArrNew;
            int count;
            if (Remove)
            {
                ArrNew = new int[Arr.Length - SeriesCount()];
                count = 0;
            }
            else
            {
                ArrNew = new int[Arr.Length + SeriesCount()];
                ArrNew[0] = Arr[0];
                ArrNew[1] = Arr[0];
                count = 2;
            }
            int buffer = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] == buffer)
                {
                    ArrNew[count++] = buffer;
                }
                if (Arr[i] != buffer || i == Arr.Length - 1)
                {
                    buffer = Arr[i];
                    if (!Remove)
                    {
                        ArrNew[count++] = buffer;
                        ArrNew[count++] = buffer;
                    }
                }
            }
            return ArrNew;
        }
        public int[] RemoveElements()
        {
            return ChangeElements(true);
        }
        public int[] AddElements()
        {
            return ChangeElements(false);
        }


        private int SymmetrySeriesCount(int index, bool Even)
        {
            int count, Li, Ri;
            if (Even)
            {
                count = 0;
                Li = index + 1;
                Ri = index;
            }
            else
            {
                count = 1;
                Li = index;
                Ri = index;
            }
            while (true)
            {
                Li--;
                Ri++;
                if (Li < 0 || Ri >= Arr.Length || Arr[Ri] != Arr[Li])
                    break;
                count += 2;
            }
            return count;
        }
        public bool SearchSymmetrySeries(out int index, out int count)
        {
            index = -1;
            count = -1;
            int indexT = 0;
            int countT = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                countT = SymmetrySeriesCount(i, false);
                indexT = i - countT / 2;
                UpdIndex(ref index, ref count, indexT, countT);
                countT = SymmetrySeriesCount(i, true);
                indexT = i - countT / 2 + 1;
                UpdIndex(ref index, ref count, indexT, countT);
            }
            return count != -1;
        }
        private static void UpdIndex(ref int index, ref int count, int indexT, int countT)
        {
            if (countT > count || countT == count && indexT < index)
            {
                index = indexT;
                count = countT;
            }
        }
        public int[] SubArr(int index, int count)
        {
            int[] ArrNew = new int[count];
            Array.Copy(Arr, index, ArrNew, 0, count);
            return ArrNew;
        }
    }
}
