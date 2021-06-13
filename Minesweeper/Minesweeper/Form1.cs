using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Minesweeper : Form
    {
        int Dim;
        Cell[][] cellmap;
        int MinesCount;
        public Minesweeper()
        {
            InitializeComponent();
        }

        void GernerateRandomMines()
        {
            for(int m=0;m<=MinesCount;m++)
            {
                int r, c;
                Random rnd = new Random();
                do {
                    r = rnd.Next(Dim);
                    c = rnd.Next(Dim);
                }
                while(cellmap[r][c].Value == -1);
                cellmap[r][c].Value = -1;

                for (int ri = r - 1; ri <= r + 1; ri++)
                {
                    if (ri < 0 || ri >= Dim)
                        continue;
                    for(int ci=c-1;ci<=c+1;ci++)
                    {
                        if (ci < 0 || ci >= Dim)
                            continue;
                        if (cellmap[ri][ci].Value != -1)
                        {
                            cellmap[ri][ci].Value++;
                        }
                    }
                }
            }
            
        }
        private void recursiveCall(Cell ccell)
        {
            ccell.IsOpen = true;
            if (ccell == null)
                return;
            for (int r = ccell.ri - 1; r <= ccell.ri + 1; r++)
            {
                if (r < 0 || r >= Dim)
                    continue;
                for (int c = ccell.ci - 1; c <= ccell.ci + 1; c++)
                {
                    //if (r == ccell.ri && c == ccell.ci)
                    //    continue;
                    if (c < 0 || c >= Dim)
                        continue;
                    if (cellmap[r][c].Value == 0 && cellmap[r][c].IsOpen == false && cellmap[r][c] != null)
                    {
                        recursiveCall(cellmap[r][c]);
                       // cellmap[r][c].Click += new System.EventHandler(this.WhenClicked);
                    }
                    cellmap[r][c].BackColor = Color.White;
                    cellmap[r][c].Text = cellmap[r][c].Value.ToString();
                    
                }
            }
        }
        private int exit()
        {
            MessageBox.Show("Game OVER!!!");
            return 0;
        }
        private void WhenClicked(object sender, EventArgs e)
        {
            Cell ClickedCell = (Cell)sender;
            ClickedCell.BackColor = Color.White;
            ClickedCell.Text = ClickedCell.Value.ToString();
            ClickedCell.IsOpen = true;
            if (ClickedCell.Value == -1)
            {
                exit();
                
            }
            if (ClickedCell.Value == 0)
                recursiveCall(ClickedCell);
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if(Level1.Checked==true)
            {
                Dim = 5;
                MinesCount = 5;
            }
            else if(Level2.Checked==true)
            {
                Dim = 10;
                MinesCount = 10;
            }
            else if(Level3.Checked==true)
            {
                Dim = 15;
                MinesCount = 15;
            }
            else
            {
                MessageBox.Show("please select a level");
                return;
            }

            cellmap = new Cell[Dim][];
            for(int i=0;i<Dim;i++)
            {
                cellmap[i] = new Cell[Dim];
            }
            CellsPanel.Controls.Clear();
            for(int r=0;r<Dim;r++)
            {
                for(int c=0;c<Dim;c++)
                {
                    cellmap[r][c] = new Cell(r,c, CellsPanel.Width, CellsPanel.Height, Dim);
                    cellmap[r][c].Click += new System.EventHandler(this.WhenClicked);
                    CellsPanel.Controls.Add(cellmap[r][c]);
                }
            }
            GernerateRandomMines();
            
        }
    }
}
