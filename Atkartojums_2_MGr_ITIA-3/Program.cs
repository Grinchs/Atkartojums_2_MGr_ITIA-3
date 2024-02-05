using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Atkartojums_2_MGr_ITIA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vards = "algoritms";
            Console.WriteLine("Raksti ar maziem burtiem :) Paldies!");
            char[] vardsCharArray = vards.ToCharArray();
            bool[] atminetieBurti = new bool[vards.Length];
            int MeginajumuSk = 0;


            char[] atminetieBurtiCharArray = new char[vards.Length];
            for (int i = 0; i < vards.Length; i++)
            {
                atminetieBurtiCharArray[i] = '_';
            }

            while (!Atminets(atminetieBurti))
            {
                Console.WriteLine(string.Join(" ", atminetieBurtiCharArray));

                Console.Write("\nIevadi burtu: ");
                char ievade = Console.ReadLine()[0];

                if (!char.IsLetter(ievade))
                {
                    Console.WriteLine("Nav burts!");
                    continue;
                }

                bool PareizaAtbilde = false;
                for (int i = 0; i < vards.Length; i++)
                {
                    if (vardsCharArray[i] == ievade && !atminetieBurti[i])
                    {
                        atminetieBurti[i] = true;
                        atminetieBurtiCharArray[i] = ievade;
                        PareizaAtbilde = true;
                        MeginajumuSk++;
                    }
                }

                if (!PareizaAtbilde)
                {
                    MeginajumuSk++; 
                }
            }
            Console.WriteLine("Meginajumu skaits " + MeginajumuSk);
        }

        static bool Atminets(bool[] atminetieBurti)
        {
            foreach (bool b in atminetieBurti)
            {
                if (!b)
                {
                    return false;
                }
            }
            return true;
        }
    }
}