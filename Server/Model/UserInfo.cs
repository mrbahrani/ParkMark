using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class UserInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserInfoID { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Plate { get; set; }
        public int Credit { get; set; }
        public int Authorisation { get; set; }

    }
}
