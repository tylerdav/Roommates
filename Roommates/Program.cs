using System;
using System.Collections.Generic;
using Roommates.Models;
using Roommates.Repositories;

namespace Roommates
{
    class Program
    {
        /// <summary>
        ///  This is the address of the database.
        ///  We define it here as a constant since it will never change.
        /// </summary>
        private const string CONNECTION_STRING = @"server=localhost\SQLExpress;database=Roommates;integrated security=true";

        static void Main(string[] args)
        {
            RoomRepository roomRepo = new RoomRepository(CONNECTION_STRING);

            Console.WriteLine("Getting All Rooms:");
            Console.WriteLine();

            List<Room> allRooms = roomRepo.GetAll();

            foreach (Room room in allRooms)
            {
                Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            }

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Getting Room with Id 1");

            //Room singleRoom = roomRepo.GetById(1);

            //Console.WriteLine($"{singleRoom.Id} {singleRoom.Name} {singleRoom.MaxOccupancy}");

            //Room bathroom = new Room
            //{
            //    Name = "Bathroom",
            //    MaxOccupancy = 1
            //};

            //roomRepo.Insert(bathroom);

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine($"Added the new Room with id {bathroom.Id}");

            //Room roomUpdate = roomRepo.GetById(1);
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine($"update Room Name with id {roomUpdate.Id}");
            //roomUpdate.Name = Console.ReadLine();
            //roomRepo.Update(roomUpdate);

            //Console.WriteLine("-------------------------------");
            //roomRepo.Delete(8);
            //Console.WriteLine("Room was deleted");


            List<Room> allRoomsAgain = roomRepo.GetAll();

            Console.WriteLine("-------------------------------");
            foreach (Room room in allRoomsAgain)
            {
                Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            }
        }
    }
}