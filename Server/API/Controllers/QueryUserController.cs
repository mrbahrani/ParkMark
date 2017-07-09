using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class QueryUserController : QueryController
    {
        [HttpPost]
        public void AddNewUser(Models.UserInfo userInfo)
        {
            _UserInfo = new Models.UserInfo();
            if (UserQueryValidate(userInfo))
            {
                _UserInfo = userInfo;
            }
        }
        [HttpPut]
        public void EditPersonalInformation(Models.UserInfo userInfo)
        {
            _UserInfo = new Models.UserInfo();
            if (UserQueryValidate(userInfo))
            {
                _UserInfo = userInfo;
            }
        }
    }
}
