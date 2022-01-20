using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            var occurenceInstance = new Program();
            Console.WriteLine("Enter your string");
            string text = Console.ReadLine();
            char[] output = GetMostFrequentChar(text);
            //if (output.Values.Distinct().Count() == output.Count)
            //{
            //    Console.WriteLine("No Rep");
            //}
            string result = string.Join("", output);
            if (result == " ")
            {
                Console.WriteLine("Max Occurence => " + '"' + '"');
            }
            else
            {
                Console.WriteLine("Max Occurence => " + result);
            }
        }

        static char[] GetMostFrequentChar(string str)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (chars.ContainsKey(c))
                    //Increases the value of a dictonary key/value pair if specificed key is found
                    chars[c]++;
                else 
                    //Adds character into dictionary with the key being the character and the value being the count which is 1
                    chars.Add(c, 1);
            }

            if (chars.Values.Distinct().Count() == 1)
            {
                Console.WriteLine("Max Occurence => No Repetition");
            }

            //returns the keys from a collection of key/value pairs with the highest frequency into a char array
            int max = chars.Values.Max();
            char[] maxValues = chars.Where(b => b.Value == max).Select(b => b.Key).ToArray();
            return maxValues;
            //return chars.Where(b => b.Value == max).Select(b => b.Key).ToArray();
        }


    }
}
