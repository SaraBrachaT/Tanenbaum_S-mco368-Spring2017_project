using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBClasses;

namespace DBModel
{
    public class Context : DbContext
    {
        public DbSet<Classes.User> Users { get; set; }
        public DbSet<Classes.Purchase> Purchases { get; set; }
        public DbSet<Classes.Item> Items { get; set; }
    }
}
