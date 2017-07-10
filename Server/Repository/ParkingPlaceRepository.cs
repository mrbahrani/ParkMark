using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.SqlServer;
namespace Repository
{
    public class ParkingPlaceRepository : IParkingPlaceRepository
    {
        public List<Model.ParkingPlace> GetPlaces(int x, int y)
        {
            Context _Context = new Context();
            //List<Model.ParkingPlace> ParkingPlacesList = _Context.ParkingPlaces.Where(e => Math.Sqrt(Math.Pow((e.X_Position - x), 2) + Math.Pow((e.Y_Position - y), 2)) <= 500).ToList();
            int max = _Context.ParkingPlaces.Max(e => e.ParkingPlaceID);
            List<int> id = new List<int>();
            List<int> xPos = new List<int>();
            List<int> yPos = new List<int>();
            List<Model.ParkingPlace> ParkingPlacesList = new List<Model.ParkingPlace>();
            Model.ParkingPlace ParkingPlace;
            id = _Context.ParkingPlaces.Select(e => e.ParkingPlaceID).ToList();
            xPos = _Context.ParkingPlaces.Select(e => e.X_Position).ToList();
            yPos = _Context.ParkingPlaces.Select(e => e.Y_Position).ToList();
            for (int i = 0; i < xPos.Count; i++)
            {
                ParkingPlace = new Model.ParkingPlace();
                ParkingPlace.ParkingPlaceID = id[i];
                ParkingPlace.X_Position = xPos[i];
                ParkingPlace.Y_Position = yPos[i];
                ParkingPlacesList.Add(ParkingPlace);
            }
            return ParkingPlacesList;
        }
        public bool GetPlaceValidility(int parkID)
        {
            Context _Context = new Context();
            Model.ParkingPlace _ParkingPlace = new Model.ParkingPlace();
            try
            {
                _ParkingPlace = _Context.ParkingPlaces.Where(e => e.ParkingPlaceID == parkID).SingleOrDefault();
            }
            catch
            {

            }
            bool Check;
            if (_ParkingPlace.UserInfoRefID == null)
            {
                Check = true;
            }
            else
            {
                Check = false;
            }
            return Check;          
        }
        public bool SetPark(int parkID, int userID)
        {
            Context _Context = new Context();
            Model.ParkingPlace _ParkingPlace = new Model.ParkingPlace();
            Model.UserInfo _UserInfo = new Model.UserInfo();
            try
            {
                _ParkingPlace = _Context.ParkingPlaces.Where(e => e.ParkingPlaceID == parkID).SingleOrDefault();
                _UserInfo = _Context.UsersInfo.Where(e => e.UserInfoID == userID).SingleOrDefault();
                _ParkingPlace.UserInfo = _UserInfo;
                _Context.Entry(_ParkingPlace).State = System.Data.Entity.EntityState.Modified;
                _Context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                string a = e.Message;
                return false;
            }            
        }
    }
}
