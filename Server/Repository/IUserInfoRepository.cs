using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserInfoRepository
    {
        bool AddNewUser(string firstName, string familyName, string username, string password, string phoneNumber, string plate, int authorisation);
        bool NotRepetitiveUsername(string username);
        bool NotRepetitivePhoneNumber(string phoneNumber);
        int CheckAuthorisation(string username);
        bool CheckAuthentication(string username, string password);
        string ChangeUserInformation(int userID, string firstName, string familyName, string username, string phoneNumber, string plate);
    }
}
