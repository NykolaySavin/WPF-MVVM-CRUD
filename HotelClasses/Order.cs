using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClasses
{
    public class Order : Base
    {
        public ICollection<Service> Services { get; set; }
        private double fixedPrice=0;
        public double Sum { get { return Room.Price + Services.Sum(item => item.Price)+fixedPrice; }  }
        public Order(Room room,Client client)
        {
            Room = room;
            Client = client;
            StartDate = DateTime.Now;
            Services = new List<Service>();
        }
        public void CrashFurniture(Furniture f)
        {
            if (Room.Furniture.Contains(f))
            {
                fixedPrice += f.Price;
                Room.Furniture.Remove(f);
            }
        }
        public void AddService(Service service)
        {
            Services.Add(service);
        }
        public void FinishOrder()
        {
            EndDate = DateTime.Now;
        }
        public  Client Client { get; set; }
        public  Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Order()
        {

        }
    }
}
