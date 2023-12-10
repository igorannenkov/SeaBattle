using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal class Cell
    {
        public enum CellState 
        {
            Empty,
            Missed,
            Undamaged,    
            Dead 
        }

        public CellState cellState;

        public Cell()
        {
            cellState = CellState.Empty;
        }

        public Cell(CellState cellState)
        { 
            this.cellState = cellState; 
        }
    }
}
