using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IParkingPlaceRepository
    {
        List<Model.ParkingPlace> GetPlace(int x, int y);
        bool GetPlaceValidility(int parkID);
        Model.ParkingPlace SetPark(int parkID, int userId);
        Model.ParkingPlace ChangePlaceInformation(Model.ParkingPlace newInfo);
    }
}
