using System;
namespace TereMaailm
{
    internal class Tervitaja
    {
        internal static void Tervita(string nimi)
        {
            Console.WriteLine("Tere, " + nimi + "!");
        }
        internal static void Tervita(string[] nimi)
        {
            for(int i = 0; i < nimi.Length; i++)
            {
                Console.WriteLine("Tere, " + nimi[i]);
            }
        }
    }
}