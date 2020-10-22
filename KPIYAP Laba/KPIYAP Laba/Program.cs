using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIYAP_Laba
{

    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room(1, 1, 1, 1);
            room.SetWindowsSize();
            Console.WriteLine(room.GetSquareOfRoom());
            Console.WriteLine(room.GetSquareForGluing());
            Console.WriteLine(room.CountOfRolls());
            Console.ReadKey();
        }
    }
}
