using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class UserInfo
    {
        public string AddNewUser(int UserInfoID, string FirstName, string FamilyName, string Username, string Password, int PhoneNumber, string Plate)
        {
            string result = "TEST";
            return result;
        }
        
        public bool AddToCredit(int value)
        {
            return true;
        }
        public bool NotRepetitive(string username, string passsword, string phoneNumber)
        {
            return true;
        }
        public string CheckAuthorisation(string username, string password)
        {
            return "TEST";
        }
        public bool CheckUserInfo(string username, string password)
        {
            return true;
        }

        public bool UpdateUserTransaction(int userID, int parkID, int placePark)
        {
            return true;
        }

        public string ChangeUserInformation(int userID, string FirstName, string FamilyName, string username, string plate)
        {
            return "TEST";
        }
    }
}
