using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IParkingPlaceRepository
    {
        List<Model.ParkingPlace> GetPlaces(int x, int y);
        bool GetPlaceValidility(int parkID);
        bool SetPark(int parkID, int userId);
    }
}
