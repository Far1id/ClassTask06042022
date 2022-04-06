using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Room
    {
        public Room(string name, double price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;

            TotalCount++;
            _id = TotalCount;
        }
        public static int TotalCount;
        int _id;
        public int Id { get=>_id; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string ShowInfo()
        {
            return Id + Name + Price + PersonCapacity + IsAvailable ;
        }
        public override string ToString()
        {
            return ShowInfo();
        }



    }
}
