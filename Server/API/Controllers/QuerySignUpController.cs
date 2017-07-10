using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class QuerySignUpController : QueryController
    {
        [HttpPost]
        public string AddNewUser(Models.UserInfo userInfo)
        {
            _UserInfo = new Models.UserInfo();
            if (UserQueryValidate(userInfo))
            {
                _UserInfo = userInfo;
                ParkMarkLogic.SignUpLogic _SignUpLogic = new ParkMarkLogic.SignUpLogic();
                string result;
                result = _SignUpLogic.AddNewUser(_UserInfo.FirstName, _UserInfo.FamilyName, _UserInfo.Username,
                        _UserInfo.Password, _UserInfo.PhoneNumber, _UserInfo.Plate, _UserInfo.Authorisation);
                return result;
            }
            else
            {
                return "Info Is Null Or Recived Bad!";
            }
        }
    }
}
