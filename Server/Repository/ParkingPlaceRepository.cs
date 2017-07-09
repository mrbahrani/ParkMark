using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ParkingPlaceRepository : IParkingPlaceRepository
    {
        public List<Model.ParkingPlace> GetPlaceObj(int x, int y)
        {
            Context _Context = new Context();
            List<Model.ParkingPlace> ParkingPlacesList = _Context.ParkingPlaces.Where(e => Math.Sqrt(Math.Pow((e.X_Position - x), 2) + Math.Pow((e.Y_Position - y), 2)) <= 500).ToList();
            return ParkingPlacesList;
        }
        public bool GetPlaceValidility(int parkID)
        {
            Context _Context = new Context();
            Model.ParkingPlace _ParkingPlaceObj = new Model.ParkingPlace();
            _ParkingPlaceObj = _Context.ParkingPlaces.Where(e => e.ParkingID == parkID).SingleOrDefault();
            bool Check;
            if(_ParkingPlaceObj.UserInfoRefID == -1)
            {
                Check = true;
            }
            else
            {
                Check = false;
            }
            return Check;
        }
        public Model.ParkingPlace SetParkObject(int parkID, int userID)
        {
            Context _Context = new Context();
            Model.ParkingPlace _ParkingPlaceObj = new Model.ParkingPlace();
            Model.UserInfo _UserInfoObj = new Model.UserInfo();
            try
            {
                _ParkingPlaceObj = _Context.ParkingPlaces.Where(e => e.ParkingID == parkID).SingleOrDefault();
                _UserInfoObj = _Context.UsersInfo.Where(e => e.UserInfoID == userID).SingleOrDefault();
                _ParkingPlaceObj.UserInfo = _UserInfoObj;
                _Context.Entry(_ParkingPlaceObj).State = System.Data.Entity.EntityState.Modified;
                _Context.SaveChanges();
                return _ParkingPlaceObj;
            }
            catch
            {
                _ParkingPlaceObj = null;
                return _ParkingPlaceObj;
            }            
        }
        public Model.ParkingPlace ChangePlaceInformation(Model.ParkingPlace newInfo)
        {
            Context _Context = new Context();
            try
            {
                _Context.Entry(newInfo).State = System.Data.Entity.EntityState.Modified;
                _Context.SaveChanges();
                return newInfo;
            }
            catch
            {
                return null;
            }
        }
    }
}
