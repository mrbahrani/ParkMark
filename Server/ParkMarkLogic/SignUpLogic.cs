using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkMarkLogic
{
    public class SignUpLogic
    {
        Repository.UserInfoRepository _UserinfoRepository = new Repository.UserInfoRepository();
        public string AddNewUser(string firstName, string familyName, string userName, string password,
            string phoneNumber, string plate, int authorisation)
        {
            if(_UserinfoRepository.NotRepetitivePhoneNumber(phoneNumber))
            {
                if(_UserinfoRepository.NotRepetitiveUsername(userName))
                {
                    if (_UserinfoRepository.AddNewUser(firstName, familyName, userName, password
                        ,phoneNumber, plate, authorisation))
                    {
                        return "ADDED SUCCESSFUL!";
                    }
                    else
                    {
                        return "UNKOWN PROBLEM!";
                    }
                }
                else
                {
                    return "USERNAME IS DUPLICATE!";
                }
            }
            else
            {
                return "PHONE NUMBER IS DUPLICATE!";
            }
        }
    }
}
