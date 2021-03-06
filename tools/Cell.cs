﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public override string ToString()
        {
            return "(" + Row + "; " + Column + ")";
        }

        public Cell(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
