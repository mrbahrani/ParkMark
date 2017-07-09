using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class QueryController : ApiController
    {
        protected Models.UserInfo _UserInfo;
        protected Models.ParkingPlace _ParkingPlace;
        public bool UserQueryValidate(Models.UserInfo userInfo)
        {
            if (userInfo != null && ModelState.IsValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ParkingPlaceQueryValidate(Models.ParkingPlace parkingPlace)
        {
            if (parkingPlace != null && ModelState.IsValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
