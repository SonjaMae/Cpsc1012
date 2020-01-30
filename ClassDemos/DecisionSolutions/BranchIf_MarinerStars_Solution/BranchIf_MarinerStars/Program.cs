using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchIf_MarinerStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int starLevel = 5;
            string msg = "";
            if (starLevel < 1)
            {
                msg = "Welcome to Holland America Cruises. You have yet to earn special benefits.";
            }
            else if (starLevel < 2)
            {
                msg = "You can receive any of the 1-Star benefits of the Mariner Program.";
            }
            else if (starLevel < 3)
            {
                msg = "You can receive any of the 2-Star benefits of the Mariner Program.";
            }
            else if (starLevel < 4)
            {
                msg = "You can receive any of the 3-Star benefits of the Mariner Program.";
            }
            else if (starLevel < 5)
            {
                msg = "You can receive any of the 4-Star benefits of the Mariner Program.";
            }
            else
            {
                msg = "You can receive any of the 5-Star benefits of the Mariner Program.";
            }

            Console.WriteLine(msg);
        }
    }
}
