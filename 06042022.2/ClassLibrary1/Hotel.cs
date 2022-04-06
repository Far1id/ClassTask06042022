using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Hotel
    {
        public string Name { get; set; }

        private Room[] Rooms = new Room[0];

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room;
        }
        public void MakeReservation(int? id)
        {
            int ID;
            foreach (var item in Rooms)
            {
                try
                {
                    ID = id;                                   

                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
    }
}
