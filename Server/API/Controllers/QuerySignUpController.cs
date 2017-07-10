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
            Repository.UserInfoRepository _UserInfoRepository = new Repository.UserInfoRepository();
            if (UserQueryValidate(userInfo))
            {
                _UserInfo = userInfo;
                if (_UserInfoRepository.NotRepetitiveUsername(_UserInfo.Username) && _UserInfoRepository.NotRepetitivePhoneNumber(_UserInfo.PhoneNumber)) ;
                {
                    return _UserInfoRepository.AddNewUser(_UserInfo.FirstName, _UserInfo.FamilyName, _UserInfo.Username,
                        _UserInfo.Password, _UserInfo.PhoneNumber, _UserInfo.Plate, _UserInfo.Authorisation);
                }
                //else
                //{
                //    return "USERNAME IS REPETED1";
                //}
            }
            else
            {
                return "Info Is Null Or Recived Bad!";
            }
        }
    }
}
