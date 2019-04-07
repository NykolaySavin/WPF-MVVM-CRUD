using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClasses
{
    public class Room : Base
    {
        public string Number { get; set; }
        public ICollection<Furniture> Furniture { get; set; }
        [NotMapped]
        public double Price { get { return Furniture.Sum(x => x.Price * 2); }  }
        public RoomState State { get; set; }
        public Room()
        {
            Furniture = new List<Furniture>();
        }
        public override string ToString()
        {
            return Number;
        }
    }

    public enum RoomState
    {
        [Description("Free")]
        Free,
        [Description("Occupied")]
        Occupied
    }
}
