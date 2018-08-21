using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UdlaanManagement.Models
{
    public class Lend
    {
        public Lend(Item itemObject, DateTime lendDate, DateTime returnDate, DateTime? returnedDate)
        {
            this.itemObject = itemObject;
            this.lendDate = lendDate;
            this.returnDate = returnDate;
            this.returnedDate = returnedDate;
        }

        public Item itemObject { get; set; }
        public DateTime lendDate { get; set; }
        public DateTime returnDate { get; set; }
        public DateTime? returnedDate { get; set; }
    }
}