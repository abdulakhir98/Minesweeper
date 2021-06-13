using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    class Cell : Button
    {
        public int ri;
        public int ci;
        public bool IsOpen;
        public int Value;

        public Cell(int r, int c, int w, int h, int dim)
        {
            ri = r;
            ci = c;
            IsOpen = false;
            Value = 0;
            this.Width = w / dim -8;
            this.Height = h / dim - 8;
        }
    }
}
