using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsList
    {
        public List<int> list { get; set; }
        public ToolsList(List<int> list)
        {
            this.list = list;
        }
        public List<int> Process(out bool success)
        {
            List<int> ListNew = Copy();
            if (ListNew.Count < 2)
            {
                success = true;
                return ListNew;
            }

            ListNew.Sort();
            int D = ListNew[1] - ListNew[0];
            for (int i = 1; i < ListNew.Count-1; i++)
            {
                if (ListNew[i + 1] - ListNew[i] != D)
                {
                    ListNew = Copy();
                    success = false;
                    return ListNew;
                }
            }
            success = true;
            return ListNew;
        }
        private List<int> Copy()
        {
            List<int> ListNew = new List<int>();
            foreach (int item in list)
            {
                ListNew.Add(item);
            }
            return ListNew;
        }
    }
}
