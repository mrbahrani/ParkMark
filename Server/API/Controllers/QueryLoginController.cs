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
            Repository.UserInfoRepository _UserinfoRepository = new Repository.UserInfoRepository();




            if (UserQueryValidate(userInfo))
            {
                _UserInfo = userInfo;
                if (_UserinfoRepository.CheckAuthentication(userInfo.Username,userInfo.Password));
                {



                }

            }
            return true;
        }
    }
}
