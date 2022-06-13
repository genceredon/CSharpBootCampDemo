using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02
{
    internal class CityPicker
    {
        public static void SwitchCaseSampleCode()
        {
            Console.WriteLine("Enter a city: ");
            string city = Console.ReadLine();

            switch (city?.ToLower())
            {
                //case "MNL":
                case "mnl":
                    Console.WriteLine("Manila");                  
                    break;
                case "DVO":
                    Console.WriteLine("Davao");
                    break;
                case "CEB":
                    Console.WriteLine("Cebu");
                    break;
                case "MPH":
                    Console.WriteLine("Caticlan");
                    break;
                case "USU":
                    Console.WriteLine("Busuanga");
                    break;
                case "CDO":
                    Console.WriteLine("Cagayan de Oro");
                    break;
                default:
                    Console.WriteLine("Invalid City");
                    break;
            }
        }       
    }
}
