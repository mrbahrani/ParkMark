using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserInfoRepository
    {
        string AddNewUser(string firstName, string familyName, string username, string password, string phoneNumber, string plate);
        bool NotRepetitiveUsername(string username);
        bool NotRepetitivePhoneNumber(string phoneNumber);
        bool CheckAuthorisation(string username, string password);
        bool CheckAuthentication(string username, string password, out int userID);
        string ChangeUserInformation(int userID, string firstName, string familyName, string username, string phoneNumber, string plate);
    }
}
