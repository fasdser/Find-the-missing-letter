using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_missing_letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
            Console.ReadLine();
        }

       
            public static char FindMissingLetter(char[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i + 1] - array[i] > 1)
                    {
                        return (char)(array[i] + 1);
                    }
                }

                return ' ';
            }

        public static char FindMissingLetter1(char[] array) => (char)(array.Where((c, i) => array[i + 1] - c != 1).First() + 1);

    }

}