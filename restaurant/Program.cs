using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class Program
    {
        static void Main(string[] args)
        {

            //int billPortion = 13;
            
            Console.WriteLine("How much did each person pay?");
            int billPortion = int.Parse(Console.ReadLine());


            // int dinnerNumber = 4;

            Console.WriteLine("How many diners are there?");
            int dinnerNumber = int.Parse(Console.ReadLine());

            int billTotal = billPortion * dinnerNumber;
            // Console.WriteLine(billTotal);

            //replace hard coded by user inputed values
            double newBill;

            if(billTotal >= 50)
            {
                newBill = billTotal * .9;
                Console.WriteLine("your discounted total is now $" + newBill);
            }
            else
            {
                newBill = billTotal * .95;
                Console.WriteLine("your discounted total is now $" + newBill);

            }


        }
    }
}
