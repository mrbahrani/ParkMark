using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace Repository
{

    public class Context : DbContext
    {
        public Context() : base("name=Context")
        {
            Database.SetInitializer<Context>(null);
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
            base.Configuration.ValidateOnSaveEnabled = false;
        }
        public DbSet<Model.ParkingPlace> ParkingPlaces { get; set; }
        public DbSet<Model.UserInfo> UsersInfo { get; set; }
    }
}
