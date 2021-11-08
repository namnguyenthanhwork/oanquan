using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    //represents for the route 
    public class RouteBLL
    {
        public static CellBLL[] route { get; set; }// main route
        public static CellBLL[] cellBLLs { get; set; } //temp route
        public static List<int> trackSteps { get; set; }//list indices uses for tracking 
        //initialize data
        public RouteBLL(CellBLL[] _route)
        {
            route = _route;
            cellBLLs = new CellBLL[12];
            trackSteps = new List<int>();
        }
        //clone a route 
        public CellBLL[] clone(CellBLL[] source)
        {
            CellBLL[] cellBLLs = new CellBLL[12];
            for (int i = 0; i < source.Length; i++)
                cellBLLs[i] = new CellBLL(source[i].idx, source[i].amo);
            return cellBLLs;
        }
        //calculate route base on chosen cell and direction
        public int calRoute(CellBLL c, bool dir)
        {
            cellBLLs = clone(route);
            trackSteps.Clear();
            return dir ? moveRight(cellBLLs, c) : moveLeft(cellBLLs, c);
        }
        //move right
        private int moveRight(CellBLL[] r, CellBLL c)
        {
            if (c.amo == 0)
                return 0;
            int binTemp = 0;
            int amo = c.amo;
            int idx = c.idx;
            // get amount trooper in current cell
            r[idx].amo = 0;
            trackSteps.Add(idx);
            while (true)
            {
                //spread troopers each cell
                while (amo > 0)
                {
                    ++idx;
                    if (idx > 11)
                        idx = 0;
                    trackSteps.Add(idx);
                    r[idx].amo++;
                    amo--;
                }
                //stop when mandarin cells have troopers or mandarin  
                if (idx == 11 && r[0].amo >= 0 || idx == 5 && r[6].amo >= 0)
                    break;
                //check if next cell is empty or not
                idx++;
                if (idx > 11)
                    idx = 0;

                if (r[idx].amo > 0)//if not empty, get amount troopers and back to continue spread
                {
                    amo = r[idx].amo;
                    r[idx].amo = 0;
                    continue;
                }
                // check if next cell empty or not
                idx++;
                if (idx > 11)
                    idx = 0;

                if (r[idx].amo == 0) // empty, stop because we have 2 consecutive blank cells
                    break;
                // eat this cell
                binTemp += r[idx].amo;
                r[idx].amo = 0;

                //check there have any cell can eat
                while (true)
                {
                    idx++;
                    if (idx > 11)
                        idx = 0;

                    if (r[idx].amo > 0 || idx == 0 || idx == 6)
                        return binTemp;
                    idx++;
                    if (idx > 11)
                        idx = 0;

                    if (r[idx].amo == 0)
                        return binTemp;
                    binTemp += r[idx].amo;
                    r[idx].amo = 0;
                }
            }
            return binTemp;
        }
        //move left
        private int moveLeft(CellBLL[] r, CellBLL c)
        {
            if (c.amo == 0)
                return 0;
            int binTemp = 0;
            int amo = c.amo;
            int idx = c.idx;
            // get amount trooper in current cell
            r[idx].amo = 0;
            trackSteps.Add(idx);
            while (true)
            {
                //spread troopers each cell
                while (amo > 0)
                {
                    --idx;
                    if (idx < 0)
                        idx = 11;
                    trackSteps.Add(idx);
                    r[idx].amo++;
                    amo--;
                }
                //stop when mandarin cells have troopers or mandarin  
                if (idx == 1 && r[0].amo >= 0 || idx == 7 && r[6].amo >= 0)
                    break;
                //check if next cell is empty or not
                idx--;
                if (idx < 0)
                    idx = 11;

                if (r[idx].amo > 0)//if not empty, get amount troopers and back to continue spread
                {
                    amo = r[idx].amo;
                    r[idx].amo = 0;
                    continue;
                }
                // check if next cell empty or not
                idx--;
                if (idx < 0)
                    idx = 11;
                if (r[idx].amo == 0) // empty, stop because we have 2 consecutive blank cells
                    break;
                // eat this cell
                binTemp += r[idx].amo;
                r[idx].amo = 0;

                //check there have any cell can eat
                while (true)
                {
                    idx--;
                    if (idx < 0)
                        idx = 11;
                    if (r[idx].amo > 0 || idx  == 0 || idx == 6)
                        return binTemp;
                    idx--;
                    if (idx < 0)
                        idx = 11;
                    if (r[idx].amo == 0 )
                        return binTemp;
                    binTemp += r[idx].amo;
                    r[idx].amo = 0;

                }
            }
            return binTemp;
        }
        //load data 
        public void load() => route = cellBLLs;

    }
}
