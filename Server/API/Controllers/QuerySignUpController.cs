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
            Repository.UserInfoRepository _UserinfoRepository = new Repository.UserInfoRepository();
            if (UserQueryValidate(userInfo))
            {
                _UserInfo = userInfo;

                if (_UserinfoRepository.NotRepetitiveUsername(_UserInfo.Username) && _UserinfoRepository.NotRepetitivePhoneNumber(_UserInfo.PhoneNumber)) ;
                {

                    _UserinfoRepository.AddNewUser(_UserInfo.FirstName, _UserInfo.FamilyName, _UserInfo.Username, _UserInfo.Password, _UserInfo.PhoneNumber,_UserInfo.Plate, _UserInfo.Authorisation);

                }


            }
            return true;
        }
    }
}
