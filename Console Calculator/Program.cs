using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            double FxdOrdCst, CryCstRate, UntCst, EcoOrdQty;
            int  DmdRate;
            Console.WriteLine("Your Name Economic Order Quantity ");
            Console.WriteLine("");
            
             try{
                Console.Write("Please enter Fixed Order Cost (0.00, $/unit): ");
                FxdOrdCst = Convert.ToDouble(Console.ReadLine());
           
                Console.Write("Please enter Demand rate(0,unit/yr): ");
                DmdRate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter Carry Cost Rate(0.00,%): ");
                CryCstRate = (Convert.ToDouble(Console.ReadLine()))/100;

                Console.Write("Please enter Unit Cost(0.00, $/unit): ");
                UntCst = Convert.ToDouble(Console.ReadLine());

                EcoOrdQty = (Math.Sqrt((2 * DmdRate * FxdOrdCst) / (CryCstRate * UntCst)));
              /*  deciPt = Math.Round(EcoOrdQty, 1);
                rudup = Math.Ceiling(EcoOrdQty); */
                Console.WriteLine("");
                Console.WriteLine("EOQ: " +EcoOrdQty.ToString("n1")+ " or "+EcoOrdQty.ToString("n0") + " (rounded)");
            }         
            catch (Exception exception)
            {
                Console.WriteLine("Error while calculating the Economic Order Qty");
                Console.WriteLine("Please check your inputs");
                Console.WriteLine(exception);
            } 
            Console.ReadKey();
        } }
}
