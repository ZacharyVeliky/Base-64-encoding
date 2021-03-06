﻿using System;
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
            int loop = 0;
            while (loop != 1) {
                int i = 0;
                string temp1;
                string temp2;
                string tempRounds;
                int rounds = 1;
                bool roundsPass = false;

                Console.WriteLine("[1] Encode");
                Console.WriteLine("[2] Decode");
                Console.WriteLine("[3] Exit");

                string input = Console.ReadLine();

                if (input != "3")
                { 
                    Console.WriteLine("How many rounds of encoding/decoding should be run. (Default is 1)");
                    while (roundsPass == false)
                    {
                        tempRounds = Console.ReadLine();
                        if (tempRounds.Length < 1)
                        {
                            roundsPass = true;
                        }

                        else
                        {
                            if (int.TryParse(tempRounds, out int n) == true)
                            {                            
                                rounds = Convert.ToInt32(tempRounds);
                                roundsPass = true;
                            }
                            else
                            {
                                Console.WriteLine("Please input a number.");
                            }
                        }
                    }

                    Console.WriteLine("");

                    if (input == "1")
                    {
                        Console.WriteLine("Enter text to be encoded");
                        string inputString = Console.ReadLine();
                        Console.WriteLine(" | ");
                        Console.WriteLine(" V ");
                        temp1 = inputString;
                        while (i < rounds)
                        {
                            temp2 = Base64Encode(temp1);
                            temp1 = temp2;
                            i++;
                            if (i == rounds)
                            {
                                Console.WriteLine(temp1);
                                Clipboard.SetText(temp1);
                            }
                        }

                        Console.WriteLine("Encoded string coppied to clipbord. Press enter to continue.\n");
                        Console.ReadKey();
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("Enter text to be decoded");
                        string inputString = Console.ReadLine();
                        Console.WriteLine(" | ");
                        Console.WriteLine(" V ");
                        temp1 = inputString;
                        while (i < rounds)
                        {
                            temp2 = Base64Decode(temp1);
                            temp1 = temp2;
                            i++;
                            if (i == rounds)
                            {
                                Console.WriteLine(temp1);
                                Clipboard.SetText(temp1);
                            }
                        }
                        Console.WriteLine("Encoded string coppied to clipbord. Press enter to continue.\n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}