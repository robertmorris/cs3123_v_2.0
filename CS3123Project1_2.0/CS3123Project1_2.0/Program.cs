using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CS3123Project1_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            char ch;
            string letters = "";
            int numbers = 0;
            string others = "";
            StreamReader reader;
            reader = new StreamReader(@"TextFile1.txt");
            do
            {
                ch = (char)reader.Read();
                
                if (Char.IsLetter(ch))
                {
                    letters += ch;
                }
                else if (Char.IsDigit(ch))
                {
                    numbers += ch;
                }
                else
                {
                    others += ch;
                }
                
            } while (!reader.EndOfStream);
            reader.Close();
            reader.Dispose();

            Console.WriteLine(letters + numbers + others);

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

        }
    }
}
