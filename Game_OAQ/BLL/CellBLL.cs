using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Cell in the game board 
    public class CellBLL
    {
        public int idx { get; set; } // index of cell
        public int amo { get; set; }// amount of element in cell

        //initialize data for cell
        public CellBLL(int idx, int amo)
        {
            this.idx = idx;
            this.amo = amo;
        }
    }
}
