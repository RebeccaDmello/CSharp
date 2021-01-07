using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double fxdOrdCst, cryCstRate, untCst,cal;
            int dmdRate;
            string deciPt, rndUp;

            Console.WriteLine("Economic Order Quantity");
            Console.WriteLine("");
            //START:
            try
            {
                Console.Write("Please enter Fixed Order Cost (0.00, $/unit): ");
                fxdOrdCst = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter Demand Rate (0, unit/yr): ");
                dmdRate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter Carry Cost Rate (0.00, %): ");
                cryCstRate = Convert.ToDouble(Console.ReadLine())/100;

                Console.Write("Please enter Unit Cost (0.00, $/unit): ");
                untCst = Convert.ToDouble(Console.ReadLine());

                cal = Math.Sqrt((2 * dmdRate * fxdOrdCst) / (cryCstRate * untCst));
                deciPt = cal.ToString("n1");
                rndUp = cal.ToString("n0");

                Console.WriteLine("");
                Console.WriteLine("EOQ: " + deciPt + " or " + rndUp + "(rounded)");
            }
            catch
            {
                Console.WriteLine("\nError while calculating the Economic Order Qty \nPlease check your inputs");
             //   goto START;
            }

            Console.ReadLine();
        }
    }
}
