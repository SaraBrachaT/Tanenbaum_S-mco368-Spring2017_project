using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClasses
{
    public class Classes
    {
        public class User
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public Double Balance { get; set; }
            
        }

        public class Purchase
        {
            public int PurchaseId { get; set; }
            public Item Item { get; set; }
            public DateTime PurchaseDate { get; set; }
            public Double Price { get; set; }
            public User User { get; set; }
         }


        public class Item
        {
            public int ItemId { get; set; }
            public String Description { get; set; }
            public Double Price { get; set; }

            public int Quantity { get; set; }
        }


    }
}
