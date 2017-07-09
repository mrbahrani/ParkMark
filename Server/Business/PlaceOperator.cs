using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business
{
    public class PlaceOperator
    {
        public string GetNearestLocation(int x, int y)
        {
            QueryParkHandler QPH = new QueryParkHandler();
            string Resp = QPH.GetPlaces(x, y);
            return "wait";
        }
        public string GelectPark(int parkId, int userId)
        {
            return "not yet!";
        }
        public int GetPay(int parkId)
        {
            return 0;
        }
    }
}
