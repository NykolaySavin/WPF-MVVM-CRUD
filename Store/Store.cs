using HotelClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore
{
    public class Store :DbContext
    {
        public Store() : base("MSSQLHotelConnection2")
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
