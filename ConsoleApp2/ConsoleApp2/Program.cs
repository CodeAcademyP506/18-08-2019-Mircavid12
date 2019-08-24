using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel[] hotels = new Hotel[3];

            hotels[0] = new Hotel() { Name = "1) Central Park Hotel", Address = "(Address: New York, Manhattan)", Rooms = new string[3] { "Single Room - 90$", "Double Room - 120$", "Triple Room - 150$" } };
            hotels[1] = new Hotel() { Name = "2) Hilton Hotel", Address = "(Address: San-Francisco, Serifzade kucesi 21)", Rooms = new string[3] { "Single Room - 65$", "Double Room - 70$", "Triple Room - 80$" } };
            hotels[2] = new Hotel() { Name = "3) Boston Park Plaza", Address = "(Address: Boston, Back Bay)", Rooms = new string[3] { "Single Room - 160$", "Double Room - 180$", "Triple Room - 200$" } };

            for(var i = 0; i < hotels.Length; i++)
            {
                Console.WriteLine(hotels[i].Name + " " + hotels[i].Address + " " + hotels[i].Rooms[0]);
            }

            bool process = true;
            while (process == true)
            {
                Console.WriteLine("Otaq qiymetleri ile tanis olmaq ucun Otel nomresini sece bilersiz:");

                var myinput = Console.ReadLine();
                for (var j = 0; j < hotels[0].Rooms.Length; j++)
                {

                    if (myinput == "1")
                    {
                        Console.WriteLine(hotels[0].Rooms[j]);
                    }
                    if (myinput == "2")
                    {
                        Console.WriteLine(hotels[1].Rooms[j]);
                    }
                    if (myinput == "3")
                    {
                        Console.WriteLine(hotels[2].Rooms[j]);
                    }

                }

                Console.WriteLine("Zehmet olmasa rezerv etmek istediyiniz otelin nomresini qeyd edin:");
                var myinput2 = Console.ReadLine();
                if (myinput2 == "1")
                {
                    Console.WriteLine("Zehmet Olmasa otag novunu secin(single,double,triple):");
                    var myinput21 = Console.ReadLine();
                    if (myinput21 == "single")
                    {
                        Console.WriteLine("Tesekkurler, telebiniz qebul olundu!");
                        Console.WriteLine("Siz " + hotels[0].Name + "-in " + hotels[0].Rooms[0] + " otagini rezerv etdiniz.");
                    }
                    if (myinput21 == "double")
                    {
                        Console.WriteLine("Tesekkurler, telebiniz qebul olundu!");
                        Console.WriteLine("Siz " + hotels[0].Name + "-in " + hotels[0].Rooms[1] + " otagini rezerv etdiniz.");
                    }
                    if (myinput21 == "triple")
                    {
                        Console.WriteLine("Tesekkurler, telebiniz qebul olundu!");
                        Console.WriteLine("Siz " + hotels[0].Name + "-in " + hotels[0].Rooms[2] + " otagini rezerv etdiniz.");
                    }
                }
                if (myinput2 == "2")
                {
                    Console.WriteLine("Zehmet Olmasa otag novunu secin(single,double,triple):");
                    var myinput22 = Console.ReadLine();
                    if (myinput22 == "single")
                    {
                        Console.WriteLine("Tesekkurler, telebiniz qebul olundu!");
                        Console.WriteLine("Siz " + hotels[1].Name + "-in " + hotels[0].Rooms[0] + " otagini rezerv etdiniz.");
                    }
                    if (myinput22 == "double")
                    {
                        Console.WriteLine("Tesekkurler, telebiniz qebul olundu!");
                        Console.WriteLine("Siz " + hotels[1].Name + "-in " + hotels[0].Rooms[1] + " otagini rezerv etdiniz.");
                    }
                    if (myinput22 == "triple")
                    {
                        Console.WriteLine("Tesekkurler, telebiniz qebul olundu!");
                        Console.WriteLine("Siz " + hotels[1].Name + "-in " + hotels[0].Rooms[2] + " otagini rezerv etdiniz.");
                    }
                }
                if (myinput2 == "3")
                {
                    Console.WriteLine("Zehmet Olmasa otag novunu secin(single,double,triple):");
                    var myinput23 = Console.ReadLine();
                    if (myinput23 == "single")
                    {
                        Console.WriteLine("Tesekkurler, telebiniz qebul olundu!");
                        Console.WriteLine("Siz " + hotels[2].Name + "-in " + hotels[0].Rooms[0] + " otagini rezerv etdiniz.");
                    }
                    if (myinput23 == "double")
                    {
                        Console.WriteLine("Tesekkurler, telebiniz qebul olundu!");
                        Console.WriteLine("Siz " + hotels[2].Name + "-in " + hotels[0].Rooms[1] + " otagini rezerv etdiniz.");
                    }
                    if (myinput23 == "triple")
                    {
                        Console.WriteLine("Tesekkurler, telebiniz qebul olundu!");
                        Console.WriteLine("Siz " + hotels[2].Name + "-in " + hotels[0].Rooms[2] + " otagini rezerv etdiniz.");
                    }
                }
            }

        }
    }

    class Hotel
    {
        public string Name;
        public string Address;
        public string[] Rooms;
    }
}
