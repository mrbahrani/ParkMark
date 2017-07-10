using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Model
{
    public class ParkingPlace
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParkingPlaceID { get; set; }
        public int X_Position { get; set; }
        public int Y_Position { get; set; }
        public int UserInfoRefID { get; set; }
        [ForeignKey("UserInfoRefID")]
        public virtual UserInfo UserInfo { get; set; }
    }
}
