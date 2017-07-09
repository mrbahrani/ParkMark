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
            if (UserQueryValidate(userInfo))
            {
                _UserInfo = userInfo;
            }
            return true;
        }
    }
}
