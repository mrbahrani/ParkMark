using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkMark
{
    public class ParkingPlace
    {
        public int ParkingID { get; set; }
        public int X_Position { get; set; }
        public int Y_Position { get; set; }
        public bool IsFull { get; set; }
    }
}
