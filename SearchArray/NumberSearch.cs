using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchArray
{
    class NumberSearch
    {
        //array
        int[] sort = new int[8];



        public void RunProgram()
        {

            //this declares the array i may change it so that the array can be larger by replacing 8 with x, same with the above array declaration.
            for (int i = 0; i < 8; i++)
            {
                sort[i] = i + 1;
            }

            //this prints out the array
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(sort[i]);
            }

            //this searchs the array starting at 0 running to 19 it reports back whether a number is or is not in the array
            int j;
            for (j = 0; j < 20; j++)
            {
                if (linear_search(j, 8, sort))
                {
                    Console.WriteLine(j + " is found in the array");
                }
                else
                {
                    Console.WriteLine(j + " is not found in the array");
                }
            }
        }


        static bool linear_search(int searchvalue, int N, int[] array)
        {
            bool isFound = false;
            int i = 0;

            while (i < N)
            {
                if (searchvalue == array[i])
                {
                    isFound = true;
                    break;
                }
                i++;
            }
            return (isFound);
        }

        static void Main(string[] args)
        {
            NumberSearch myNumberSort = new NumberSearch();
            myNumberSort.RunProgram();



            Console.WriteLine("\n\n===============================");
            Console.WriteLine("NumberSearch: Press any key to finish");
            Console.ReadKey();
        }
    }
}
