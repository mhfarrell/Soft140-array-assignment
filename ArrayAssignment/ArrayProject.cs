using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class ArrayProject
    {      

        static Random _random = new Random();
        
        static void Main(string[] args)
        {
            ArrayProject myNumberShuffle = new ArrayProject();
            myNumberShuffle.RunProgram();

            Console.WriteLine("\n\n===============================");
            Console.WriteLine("Array Project: Press any key to finish");
            Console.ReadKey();

        }

        public void RunProgram()
        {
            int a = 0;
            int b = 0;
            string word = "true";
            //this short segment asks for user input to set the array size
            int sum = 0;
            Console.Write("Please Enter the size of the array  ");
            sum = Int32.Parse(Console.ReadLine());
            int[] sort = new int[sum];

            //this declares the array
            for (int i = 0; i < sum; i++)
            {
                sort[i] = i + 1;
            }

            //this prints the array in order
            for (int i = 0; i < sum; i++)
            {
                Console.WriteLine(sort[i]);                
            }
            Console.WriteLine("\n");

            //this shuffles the array into a random order
            //the array can be any size this will auto detect it
            var random = _random;
            for (int i = sum; i > 1; i--)
            {
                //i could not think of line or lines of code to replace random.Next(i) so i have kept it so my code runs
                int j = random.Next(i);
                int tmp = sort[j];
                sort[j] = sort[i - 1];
                sort[i - 1] = tmp;

            }

            //this prints out the array after the shuffle
            for (int i = 0; i < sum; i++)
            {
                Console.WriteLine(sort[i]);
            }
            Console.WriteLine("\n");

            //This asks you to input a number you would like to search for using a linear search
            int s;
            Console.Write("Please Enter a number in the array you want to search for  ");
            s = Int32.Parse(Console.ReadLine());          
                
            //this searchs the array starting at 0 running to sum+1 it reports back whether a number is or is not in the array
            int k = 0;
            int sumup = sum + 1;
            for (k = 0; k < sumup; k++)
            {
                if (linear_search(s, sum, sort))
                {
                    Console.WriteLine(s + " is found in the array");
                    break;
                }
                else
                {
                    Console.WriteLine(s + " is not found in the array");
                    break;
                }
            }

            //this is for question 4, iv had trouble working this out, so i come up with a solution that works based on a
            //2 by 2 array, while solving a 2v2 rubix cube i realised that each value has to be the same else either rows, 
            //columns or diagonals will be different
            // as i could not come up with a full solution this will only work for a 2 by 2 array possibily any combination of 2d in low numbers but 
            //it is with reduced acuracy
                int[,] dimension = new int[2, 2] { { 3, 2 }, { 2, 2 } };
                for (a = 0; a < 2; a++)
                {
                    if (dimension[a, b] == dimension[0, 0])
                    {

                    }
                    else
                    {
                        word = "false";
                        break;
                    }

                    for (b = 0; b < 2; b++)
                    {
                        if (dimension[a, b] == dimension[0, 0])
                        {

                        }
                        else
                        {
                            word = "false";
                            break;
                        }
                    }
                }

            //if a value does not match it will void the whole array and confirm the array dont match.
                Console.WriteLine("\n");
                if (word == "false")
                {
                    Console.WriteLine("This Array does not match");
                }
                else
                {
                    Console.WriteLine("This Array does match");
                }
            



        }


        //this whole linear search is based off lecture slides, works very smoothly
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

    }
}
