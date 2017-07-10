using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class QueryLoginController : QueryController
    {
        [HttpPost]
        public bool IsUserValid(Models.UserInfo userInfo)
        {          
            _UserInfo = new Models.UserInfo();
            ParkMarkLogic.Login _Login = new ParkMarkLogic.Login();
            if (UserQueryValidate(userInfo))
            {
                _UserInfo = userInfo;
                bool result = _Login.UserLogin(_UserInfo.Username, _UserInfo.Password);
                return result;
            }
            return false;
        }
    }
}
