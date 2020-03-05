using System;

namespace CommunityFragenSyn1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gebe einen Text ein: ");
            string text = Console.ReadLine();
            char[] sUD = new char[text.Length];
            for (int x = 0; x < text.Length; x++)
            {
                sUD[x] = text[x];
            }
            Console.WriteLine();
            Console.WriteLine($"Der eingegebene Text hat: {sUD.Length} Zeichnen");
            foreach (char zeichen in sUD)
            {
                Console.WriteLine(zeichen);
            }
        }
    }
}
