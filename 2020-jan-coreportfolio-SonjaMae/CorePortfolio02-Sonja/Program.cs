using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio02_Sonja
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Purpose: Compute a customer's bill for Stoney Gravel Pit.
             * Input: Input the desired amount of gravel in lbs;
             *        Input for delivery (y or not y);
             * Process: Calculate the total cost including GST and delivery charge (if not qualifying for free delivery);
             * Output: Display the weight purchased,
             *                  charge,
             *                  subtotal,
             *                  delivery charge,
             *                  GST,
             *                  total;
             * Author: Sonja Holowaychuk
             * Last modified: 2020.Feb.3
             */

            string gravelRequest;
            int gravelInt;
            double chargeAmount = 0;

            string deliveryRequest;
            double deliveryAmount = 0;

            double subtotalAmount;
            double gstAmount;
            double totalAmount;

            Console.WriteLine("Welcome to Stoney Gravel Pit!\n");

            //gravel amount
            Console.Write("Please enter the weight of gravel required (in lbs.):\t");
            gravelRequest = Console.ReadLine();
            gravelInt = int.Parse(gravelRequest);
            if (gravelInt > 0 && gravelInt < 1000)
            {
                chargeAmount = gravelInt * 0.55;
            }
            else if (gravelInt >= 1000 && gravelInt <= 2000)
            {
                chargeAmount = gravelInt * 0.45;
            }
            else if (gravelInt >= 2001 && gravelInt <= 3000)
            {
                chargeAmount = gravelInt * 0.35;
            }
            else if (gravelInt >= 3001 && gravelInt <= 4000)
            {
                chargeAmount = gravelInt * 0.25;
            }
            else if (gravelInt >= 4001 && gravelInt <= 5000)
            {
                chargeAmount = gravelInt * 0.15;
            }
            else if (gravelInt > 5000)
            {
                chargeAmount = gravelInt * 0.10;
            }

            //delivery
            Console.Write("Do you require delivery (Y/N)?:\t");
            deliveryRequest = Console.ReadLine();
            switch (deliveryRequest)
            {
                case "y":
                case "Y":
                    {
                        if (gravelInt < 0 && gravelInt <= 4800)
                        {
                            deliveryAmount = chargeAmount * 0.03;
                        }
                        else if (gravelInt > 4800)
                        {
                            deliveryAmount = 0;
                        }
                        break;
                    }
                default:
                    {
                        deliveryAmount = 0;
                        break;
                    }
                
            }

            //subtotal
            subtotalAmount = chargeAmount + deliveryAmount;

            //GST
            gstAmount = (subtotalAmount * 0.05);

            //total
            totalAmount = subtotalAmount + gstAmount;

            //output
            Console.WriteLine($"The charge for {gravelRequest} lbs. of gravel is {totalAmount:c} per lb.");
            Console.WriteLine("{chargeAmount,2:c}, chargeAmount)");
            Console.WriteLine("Thank you for your purchase! We hope your day rocks.");
            Console.ReadKey();
        }
    }
}
