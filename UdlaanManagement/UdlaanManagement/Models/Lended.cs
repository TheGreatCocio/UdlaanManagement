using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UdlaanManagement.Models
{
    public class Lended
    {
        public Lended(User UserObject, List<Lend> LendObjects)
        {
            this.UserObject = UserObject;
            this.LendObjects = LendObjects;
        }

        public User UserObject { get; set; }
        public List<Lend> LendObjects { get; set; }
    }
}