using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class UserInfoRepository : IUserInfoRepository
    {
        public bool AddNewUser(string firstName, string familyName, string username, string password, string phoneNumber, string plate , int authorisation)
        {
            Context _Context = new Context();
            Model.UserInfo _UserInfoObj = new Model.UserInfo()
            {
                FirstName = firstName,
                FamilyName = familyName,
                Username = username,
                Password = password,
                PhoneNumber = phoneNumber,
                Plate = plate,
                Authorisation = authorisation
            };
            _Context.UsersInfo.Add(_UserInfoObj);
            _Context.SaveChanges();
            return true;
        }

        public bool NotRepetitiveUsername(string username)
        {
            Context _Context = new Context();
            return !(_Context.UsersInfo.Any(e => e.Username == username));
        }
        public bool NotRepetitivePhoneNumber(string phoneNumber)
        {
            Context _Context = new Context();
            return !((_Context.UsersInfo.Any(e => e.PhoneNumber == phoneNumber)));
        }
        public int CheckAuthorisation(string username)
        {
            Context _Context = new Context();
            Model.UserInfo _UserInfo = _Context.UsersInfo.Where(e => e.Username == username).SingleOrDefault();
            return _UserInfo.Authorisation;
        }
        public bool CheckAuthentication(string username, string password)
        {
            Context _Context = new Context();
            return _Context.UsersInfo.Any(e => e.Username == username && e.Password == password);
        }

        public string ChangeUserInformation(int userID, string firstName, string familyName, string username, string phoneNumber, string plate)
        {
            Context _Context = new Context();
            Model.UserInfo _UserInfoObj = _Context.UsersInfo.Where(e => e.UserInfoID == userID).SingleOrDefault();
            _UserInfoObj = new Model.UserInfo()
            {
                FirstName = firstName,
                FamilyName = familyName,
                Username = username,
                PhoneNumber = phoneNumber,
                Plate = plate
            };
            _Context.Entry(_UserInfoObj).State = System.Data.Entity.EntityState.Modified;
            _Context.SaveChanges();
            return "Changed Successful!";
        }
    }
}
