using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkMarkLogic
{
    public class ParkingPlaceLogic
    {
        Repository.ParkingPlaceRepository _ParkingPlaceRepository;
        public List<Model.ParkingPlace> GetPlaces(int x, int y)
        {
            List<Model.ParkingPlace> Places = new List<Model.ParkingPlace>();
            _ParkingPlaceRepository = new Repository.ParkingPlaceRepository();
            Places = _ParkingPlaceRepository.GetPlaces(x, y);
            return Places;
        }
        public bool GetPlaceValidity(int parkingID)
        {
            _ParkingPlaceRepository = new Repository.ParkingPlaceRepository();
            bool result;
            result = _ParkingPlaceRepository.GetPlaceValidility(parkingID);
            return result;
        }
        public bool SetPark(int parkID, int userID)
        {
            _ParkingPlaceRepository = new Repository.ParkingPlaceRepository();          
            bool result;
            result = _ParkingPlaceRepository.SetPark(parkID, userID);
            return result;
        }
    }
}
