using System;
using System.Collections.Generic;

namespace Roman_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            var romNumerals = new Dictionary<char,int>();
            
            romNumerals.Add('I', 1);
            romNumerals.Add('V', 5);
            romNumerals.Add('X', 10);
            romNumerals.Add('L', 50);
            romNumerals.Add('C', 100);
            romNumerals.Add('D', 500);
            romNumerals.Add('M', 1000);

            /* System.Console.WriteLine(romNumerals['V']+romNumerals['M']);
            System.Console.WriteLine(args[0].Length); */

            string currArg = args[0];
           
            var result = 0;
            for (int i = 0; i < currArg.Length; i++)
            {
                
                if ((i < currArg.Length - 1) && (romNumerals[currArg[i]] < romNumerals[currArg[i+1]]))
                {
                    result += romNumerals[currArg[i+1]] - romNumerals[currArg[i]];
                    i += 1;
                }

                else
                {
                    result += romNumerals[currArg[i]];
                }
            }

            System.Console.WriteLine(result);

        }
    }
}