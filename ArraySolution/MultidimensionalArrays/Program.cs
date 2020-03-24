using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 dimensional array (rows, columns):
            int[,] array2D = new int[5, 3];

            //accessing a cell in your array reuires you to specify 2 indexes, a row index and a column index
            //syntax:   arrayname[rowindex,columnindex]
            for(int r = 0; r < 5; r++)
            {
                array2D[r, 0] = 1;
            }

            for (int r = 0; r < 5; r++)
            {
                array2D[r, 1] = r;
            }

            for (int r = 0; r < 5; r++)
            {
                array2D[r, 2] = array2D[r, 0] + array2D[r, 1];
            }

            //first for is to move between rows
            for(int r = 0; r < 5; r++)
            {
                //second for is to move between columns
                for(int c = 0; c < 3; c++)
                {
                    Console.Write($"{array2D[r, c],10}");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
