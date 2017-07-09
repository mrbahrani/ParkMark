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
        public bool AddNewUser(Models.UserInfo userInfo)
        {
            _UserInfo = new Models.UserInfo();
            if (UserQueryValidate(userInfo))
            {
                _UserInfo = userInfo;
            }
            return true;
        }
    }
}
