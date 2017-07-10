using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class QueryParkController : QueryController
    {
        ParkMarkLogic.ParkingPlaceLogic _ParkingPlaceLogic;
        [HttpPost]
        public IEnumerable<Models.ParkingPlace> GetPlaces(Models.ParkingPlace parkingPlace)
        {
            List<Models.ParkingPlace> _ParkingPlacesList = new List<Models.ParkingPlace>();
            _ParkingPlaceLogic = new ParkMarkLogic.ParkingPlaceLogic();
            foreach(var p in _ParkingPlaceLogic.GetPlaces(parkingPlace.X_Position, parkingPlace.Y_Position))
            {
                _ParkingPlacesList.Add(new Models.ParkingPlace
                {
                    ParkingID = p.ParkingPlaceID,
                    X_Position = p.X_Position,
                    Y_Position = p.Y_Position
                }
                );
            }
            return _ParkingPlacesList;
        }
        [HttpPost]
        public bool GetPlaceValidity(Models.ParkingPlace parkingPlace)
        {
            _ParkingPlace = new Models.ParkingPlace();
            _ParkingPlaceLogic = new ParkMarkLogic.ParkingPlaceLogic();
            if (ParkingPlaceQueryValidate(parkingPlace))
            {
                _ParkingPlace = parkingPlace;
                bool result;
                result = _ParkingPlaceLogic.GetPlaceValidity(_ParkingPlace.ParkingID);
                return result;
            }
            else
            {
                return false;
            }
        }
        [HttpPost]
        public bool SetPark(Models.ParkingPlace parkingPlace, Models.UserInfo userInfo)
        {
            _ParkingPlace = new Models.ParkingPlace();
            _UserInfo = new Models.UserInfo();
            _ParkingPlaceLogic = new ParkMarkLogic.ParkingPlaceLogic();
            if (ParkingPlaceQueryValidate(parkingPlace) && UserQueryValidate(userInfo))
            {
                _ParkingPlace = parkingPlace;
                _UserInfo = userInfo;
                bool result;
                result = _ParkingPlaceLogic.SetPark(_ParkingPlace.ParkingID, _UserInfo.UserInfoID);
                return result;
            }
            else
            {
                return false;
            }
        }
    }
}
