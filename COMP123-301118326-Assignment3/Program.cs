using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_301118326_Assignment3
{
    public class Program

        //Name = Arshdeep Singh
        //Student Id no = 301118326
        //Course =  Programming 2
        //Assignment no =3
        

        // This is the Main Method of the program 
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Neptune", 49244, 17.15, "Ice");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mercury", 4879.5, 0.055, false);
            Console.WriteLine(terrestrialPlanet.ToString());


            waitForAnyKey();

        }
        // waitForAnyKey
        static void waitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}