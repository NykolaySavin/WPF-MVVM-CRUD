using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClasses
{
    public class Order : Base
    {
        public ICollection<Service> Services { get; set; }
        private double fixedPrice=0;
        [NotMapped]
        public double Sum { get { if (Room != null && Services != null) return Room.Price + Services.Sum(item => item.Price) + fixedPrice; return 0; }  }
        public Order(Room room,Client client)
        {
            Room = room;
            Room.State = RoomState.Occupied;
            Client = client;
            StartDate = DateTime.Now;
            Services = new List<Service>();
        }
        [Column(Order = 1)]
        public  Client Client { get; set; }
        [Column(Order = 2)]
        public  Room Room { get; set; }
        public DateTime StartDate { get; }
        public DateTime? EndDate { get; set; }
        public void FinishOrder()
        {
            EndDate = DateTime.Now;
            Room.State = RoomState.Free;
        }
        public void UseService(Service service)
        {
            Services.Add(service);
        }
        public Order()
        {
            Services = new List<Service>();
        }
    }
}
