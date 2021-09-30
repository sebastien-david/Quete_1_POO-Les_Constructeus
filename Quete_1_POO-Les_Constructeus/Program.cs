using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_1_POO_Les_Constructeus
{
    class Program
    {
        static void Main(string[] args)
        {
            Building batiment1 = new Building(20, 55);
            Building batiment2 = new Building(15);

            Console.WriteLine(" Concernant le batiment 1 (nombre d'etage et hauteur)\n");
            Console.WriteLine(" Le nombre d'étage est de: " + (batiment1.GetFloorCount()));
            Console.WriteLine(" La hauteur du batiment est de: " + (batiment1.GetSize()) + " m");
            Console.WriteLine(" La hauteur maximale d'un étage est de: " + (batiment1.GetFloorMaxSize()) + " m");

            Console.WriteLine("\n Concernant le batiment 2 (nombre d'etage)\n");
            Console.WriteLine(" Le nombre d'étage est de: " + (batiment2.GetFloorCount()));
            Console.WriteLine(" La hauteur du batiment est de: " + (batiment2.GetSize()) + " m");
            Console.WriteLine(" La hauteur maximale d'un étage est de: " + (batiment2.GetFloorMaxSize()) + " m");

            Console.ReadLine();
        }
    }
}
