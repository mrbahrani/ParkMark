using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkMarkLogic
{
    public class Login
    {
        Repository.UserInfoRepository _UserinfoRepository;
        public bool UserLogin(string userName, string password)
        {
            _UserinfoRepository = new Repository.UserInfoRepository();
            bool result = (_UserinfoRepository.CheckAuthentication(userName, password));
            return result;
        }
    }
}
