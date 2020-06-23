using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b64
{
    class Program
    {
        public static string Base64Encode(string plainText)
                {
                    var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                    return System.Convert.ToBase64String(plainTextBytes);
                }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        static void Main(string[] args)
        {
            Top:
            Console.WriteLine("[1] Encode");
            Console.WriteLine("[2] Decode");
            
            string input = Console.ReadLine();
            Console.WriteLine("");
            if(input == "1")
            {
                Console.WriteLine("Enter text to be encoded");
                string inputString = Console.ReadLine();
                Console.WriteLine(Base64Encode(inputString) + "\n");
                Console.ReadKey();
                goto Top;
            }
            else
            {
                Console.WriteLine("Enter text to be decoded");
                string inputString = Console.ReadLine();
                Console.WriteLine(Base64Decode(inputString) + "\n");
                Console.ReadKey();
                goto Top;
            }
        }
        public void Update()
        {
            


        }
    }
}
