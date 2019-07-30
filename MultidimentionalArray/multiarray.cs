using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimentional_Array
{
    class multiarray
    {
        int sum = 0;


        public void RunProgram()
        {
            sum = 0;
            
            int a = 0;            
            int b = 0;
            string word = "true";
            int[,] array = new int[2, 2] { { 3, 2 }, { 2, 2 } };
            for(a = 0; a < 2; a++)
            {                
                if (array[a, b] == array[0,0])
                {
                    
                 }
                else 
                {
                    word = "false";
                    break;                     
                }

                for (b = 0; b < 2; b++)
                {                    
                    if (array[a, b] == array[0, 0]) 
                    {
                        
                    }
                    else 
                    {
                        word = "false";
                        break;
                    }
                }
            }
            
            if (word == "false")
            {
                Console.WriteLine("This Array does not match");
            }
            else
            {
                Console.WriteLine("This Array does match");
            }

        }

        static void Main(string[] args)
        {
            multiarray myNumberSort = new multiarray();
            myNumberSort.RunProgram();



            Console.WriteLine("\n\n===============================");
            Console.WriteLine("Multi Dimentional Array: Press any key to finish");
            Console.ReadKey();
        }
    }
}
