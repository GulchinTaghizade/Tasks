using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting
{
    static class ExtensionMethods
    {
        public static Boolean CustomContains(this string str, string contain)
        {
            Boolean result = str.Contains(contain);
            return result;
        }
        public static Boolean CustomContains(this string str, char contain)
        {
            Boolean result = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (contain == str[i])
                {
                    result = true;
                }

            }
            return result;


        }

        public static Boolean IsPrime(this int num)
        {
            bool check = false;
            if (num==1)
            {
                Console.WriteLine("Ne sade ne de murekkeb.");
            }
            else
            {
                
                int counter = 2;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    check = true;
                    return check;
                }
                
            }
            return check;
            

        }


    }
}
