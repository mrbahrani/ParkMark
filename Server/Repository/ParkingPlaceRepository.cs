using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ParkingPlaceRepository : IParkingPlaceRepository
    {
        public List<Model.ParkingPlace> GetPlace(int x, int y)
        {
            Context _Context = new Context();
            List<Model.ParkingPlace> ParkingPlacesList = _Context.ParkingPlaces.Where(e => Math.Sqrt(Math.Pow((e.X_Position - x), 2) + Math.Pow((e.Y_Position - y), 2)) <= 500).ToList();
            return ParkingPlacesList;
        }
        public bool GetPlaceValidility(int parkID)
        {
            Context _Context = new Context();
            Model.ParkingPlace _ParkingPlace = new Model.ParkingPlace();
            _ParkingPlace = _Context.ParkingPlaces.Where(e => e.ParkingID == parkID).SingleOrDefault();
            bool Check;
            if(_ParkingPlace.UserInfoRefID == -1)
            {
                Check = true;
            }
            else
            {
                Check = false;
            }
            return Check;
        }
        public Model.ParkingPlace SetPark(int parkID, int userID)
        {
            Context _Context = new Context();
            Model.ParkingPlace _ParkingPlace = new Model.ParkingPlace();
            Model.UserInfo _UserInfo = new Model.UserInfo();
            try
            {
                _ParkingPlace = _Context.ParkingPlaces.Where(e => e.ParkingID == parkID).SingleOrDefault();
                _UserInfo = _Context.UsersInfo.Where(e => e.UserInfoID == userID).SingleOrDefault();
                _ParkingPlace.UserInfo = _UserInfo;
                _Context.Entry(_ParkingPlace).State = System.Data.Entity.EntityState.Modified;
                _Context.SaveChanges();
                return _ParkingPlace;
            }
            catch
            {
                _ParkingPlace = null;
                return _ParkingPlace;
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
