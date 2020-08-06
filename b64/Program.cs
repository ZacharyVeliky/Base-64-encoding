using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        [STAThread]
        static void Main(string[] args)
        {
            Top:
            int i = 0;
            string temp1;
            string temp2;
            
            Console.WriteLine("[1] Encode");
            Console.WriteLine("[2] Decode");
            
            string input = Console.ReadLine();

            Console.WriteLine("How many rounds of encoding/decoding should be run. (Default is 1)");

            int rounds;

            string tempInput = Console.ReadLine();

            if (tempInput.Length < 1)
                rounds = 1;

            else
                rounds = Convert.ToInt32(tempInput);
            
            Console.WriteLine("");

            if(input == "1")
            {
                Console.WriteLine("Enter text to be encoded");
                string inputString = Console.ReadLine();
                Console.WriteLine(" | ");
                Console.WriteLine(" V ");
                temp1 = inputString;
                while (i < rounds){
                    temp2 = Base64Encode(temp1);
                    temp1 = temp2;
                    i++;
                    if (i == rounds){
                        Console.WriteLine(temp1);
                        Clipboard.SetText(temp1);
                        }
                }
                
                Console.WriteLine("Encoded string coppied to clipbord. Press enter to continue.\n");
                Console.ReadKey();
                goto Top;
            }
            else
            {
                Console.WriteLine("Enter text to be decoded");
                string inputString = Console.ReadLine();
                Console.WriteLine(" | ");
                Console.WriteLine(" V ");
                temp1 = inputString;
                while (i < rounds){
                    temp2 = Base64Decode(temp1);
                    temp1 = temp2;
                    i++;
                    if (i == rounds){
                        Console.WriteLine(temp1);
                        Clipboard.SetText(temp1);
                        }
                }

                Console.WriteLine("Encoded string coppied to clipbord. Press enter to continue.\n");
                Console.ReadKey();
                goto Top;
            }
        }
        public void Update()
        {

        }
    }
}