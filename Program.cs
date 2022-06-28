using System;
using System.Collections.Generic;

namespace Roman_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //the dictionary that contains all roman numerals and their integer keys
            var romNumerals = new Dictionary<char,int>();
            
            romNumerals.Add('I', 1);
            romNumerals.Add('V', 5);
            romNumerals.Add('X', 10);
            romNumerals.Add('L', 50);
            romNumerals.Add('C', 100);
            romNumerals.Add('D', 500);
            romNumerals.Add('M', 1000);

            //get the string of roman numerals from the console into a variable, helps keep code clean
            string currArg = args[0];
           
            //int var to hold the value of roman num
            var romNumVal = 0;

            //for loop to iterate over the chars in currArg string. Starts at 0, end before it reaches length of string
            for (int i = 0; i < currArg.Length; i++)
            {
                
                //first checks to see if we're at last character. If not, then check to see if next character is bigger
                if ((i < currArg.Length - 1) && (romNumerals[currArg[i]] < romNumerals[currArg[i+1]]))
                {
                    
                    //if the next char is bigger, subtract the current char from the next and add resulting value to romNumVal
                    romNumVal += romNumerals[currArg[i+1]] - romNumerals[currArg[i]];
                    
                    //then, skip ahead one in iteration order since we already counted this
                    i += 1;
                }

                //if number isn't subtracting the one ahead, then add it to romNumVal
                else
                {
                    romNumVal += romNumerals[currArg[i]];
                }
            }

            //output
            System.Console.WriteLine(romNumVal);
        }
    }
}