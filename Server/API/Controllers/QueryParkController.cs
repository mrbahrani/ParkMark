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
        [HttpGet]
        public IEnumerable<Models.ParkingPlace> GetPlaces()
        {
            List<Models.ParkingPlace> _ParkingPlacesList = new List<Models.ParkingPlace>();
            return _ParkingPlacesList;
        }
        [HttpGet]
        public bool GetPlaceValidity(Models.ParkingPlace parkingPlace)
        {
            _ParkingPlace = new Models.ParkingPlace();
            if (ParkingPlaceQueryValidate(parkingPlace))
            {
                _ParkingPlace = parkingPlace;
            }
            return true;
        }
        [HttpPut]
        public bool SetPark(Models.ParkingPlace parkingPlace, Models.UserInfo userInfo)
        {
            _ParkingPlace = new Models.ParkingPlace();
            _UserInfo = new Models.UserInfo();
            if (ParkingPlaceQueryValidate(parkingPlace) && UserQueryValidate(userInfo))
            {
                _ParkingPlace = parkingPlace;
                _UserInfo = userInfo;
            }
            return true;
        }
        [HttpPut]
        public string SendNewInfo(Models.ParkingPlace parkingPlace)
        {
            _ParkingPlace = new Models.ParkingPlace();
            if (ParkingPlaceQueryValidate(parkingPlace))
            {
                _ParkingPlace = parkingPlace;
            }
            return "";
        }
    }
}
