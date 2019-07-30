using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NumberSort
    {
        //array
       
        



        public void RunProgram()
        {
            int sum = 0;
            Console.Write("Please Enter the size of the array  ");
            sum = Int32.Parse(Console.ReadLine());
            int[] sort = new int[sum];
            //this declares the array
            for (int i = 0; i < sum; i++)
            {
                sort[i] = i + 1;
            }

            //this prints out the array
            for (int i = 0; i < sum; i++)
            {
                Console.WriteLine(sort[i]);
            }

        }


        static void Main(string[] args)
        {
            NumberSort myNumberSort = new NumberSort();
            myNumberSort.RunProgram();

            Console.WriteLine("\n\n===============================");
            Console.WriteLine("NumberSort: Press any key to finish");
            Console.ReadKey();

        }
    }
}
