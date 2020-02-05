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
            double gravelAmount = 0;

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
                chargeAmount = 0.55;
                gravelAmount = gravelInt * chargeAmount;
            }
            else if (gravelInt >= 1000 && gravelInt <= 2000)
            {
                chargeAmount =  0.45;
                gravelAmount = gravelInt * chargeAmount;
            }
            else if (gravelInt >= 2001 && gravelInt <= 3000)
            {
                chargeAmount = 0.35;
                gravelAmount = gravelInt * chargeAmount;
            }
            else if (gravelInt >= 3001 && gravelInt <= 4000)
            {
                chargeAmount = 0.25;
                gravelAmount = gravelInt * chargeAmount;
            }
            else if (gravelInt >= 4001 && gravelInt <= 5000)
            {
                chargeAmount = 0.15;
                gravelAmount = gravelInt * chargeAmount;
            }
            else if (gravelInt > 5000)
            {
                chargeAmount = 0.10;
                gravelAmount = gravelInt * chargeAmount;
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
                            deliveryAmount = gravelAmount * 0.03;
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
            subtotalAmount = gravelAmount + deliveryAmount;

            //GST
            gstAmount = (subtotalAmount * 0.05);

            //total
            totalAmount = subtotalAmount + gstAmount;

            //output
            Console.WriteLine("\n");
            Console.WriteLine($"The charge for {gravelRequest} lbs. of gravel is {chargeAmount:c} per lb.");
            Console.WriteLine("Subtotal: {0,2:c}", subtotalAmount);
            Console.WriteLine("Delivery: {0,4:c}", deliveryAmount);
            Console.WriteLine("GST: {0,11:c}", gstAmount);
            Console.WriteLine("---------------");
            Console.WriteLine("Total: {0,2:c}", totalAmount);
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for your purchase! We hope your day rocks.");
            Console.ReadKey();
        }
    }
}
