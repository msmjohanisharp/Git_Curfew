using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curfew in Saudi Arabia");
            Console.WriteLine("**********************************************************************************");

            List<City> list=  City.getAllCityHigherCurfew();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(" [ " +list[i].cityName + " ] ");
            }


            List<City> listlower = City.getAllCityLowerCurfew();
            for (int i = 0; i < listlower.Count; i++)
            {
                Console.Write(" [ " + listlower[i].cityName + " ] ");
            }

            Console.WriteLine("");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Please Type City From Top ");
            string cityName = Console.ReadLine();
            var checklistHigher = list.Where(xx => xx.cityName == cityName).ToList();
            var checklistlower = listlower.Where(xx => xx.cityName == cityName).ToList();
            TimeSpan start = TimeSpan.Parse("15:00"); // 3:00 PM
            TimeSpan end = TimeSpan.Parse("06:00");   // 6:00 AM
            TimeSpan now = DateTime.Now.TimeOfDay;
            Console.WriteLine("");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("");
            Console.WriteLine("");

            if (checklistHigher.Count >0)
            {
                Console.WriteLine(cityName + " The Curfew Begin from 3:00 pm to 6:00 am ");
                if (now >= start  || now  <=end)

                {
                    Console.WriteLine("The Time Now : " + DateTime.Now.ToString("t") + " under curfew ");
                }
                else
                {
                    Console.WriteLine("The Time Now : " + DateTime.Now.ToString("t") + "  no curfew ");
                }
            }
            else if (checklistlower.Count >0)
            {
                Console.WriteLine(cityName + " The Curfew Begin from 7:00 pm to 3:00 am ");
                if ((now < start) && (now > end))

                {
                    Console.WriteLine("The Time Now : " + DateTime.Now.ToString("t") + "  no curfew ");
                }
                else
                {
                    Console.WriteLine("The Time Now : " + DateTime.Now.ToString("t") + " under curfew ");

                }
            }
            else
            {
                Console.WriteLine("sorry " + cityName + " Not found ");

            }
          

        }
    }
}
