﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assesment_Test_4
{
    class FizzBuzzNo
    {

        public static void Main()
        {
            int n = 50;

          
            for (int i = 1; i <= n; i++)
            {

               
                
                if (i % 15 == 0)
                    Console.Write("FizzBuzz" + " ");

                
                
              
                else if (i % 3 == 0)
                    Console.Write("Fizz" + " ");


                else if (i % 5 == 0)
                    Console.Write("Buzz" + " ");

                
                else
                    Console.Write(i + " ");
            }
        }
    }
}
    
