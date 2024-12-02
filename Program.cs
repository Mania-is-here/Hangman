using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programmiere das Spiel Hangman. User 1 soll ein Wort eingeben.
            //User 2 muss danach eine Eingabe machen entweder für einen Buchstaben oder das gesuchte Wort.
            //User 2 Gewinnt wenn er entweder alle Buchstaben oder das richte Wort erraten hat.
            //Ansonsten baut sich der Galgen auf mit folgender Ausgabe als Finale:

            //
            //"  ======||  "
            //"  |     ||  "
            //"  O     ||  "
            //" -x-    ||  "
            //"  x     ||  "
            //" | |    ||  "
            //"        ||  "
            //"============"
            //
            //Ist der Galgen fertig aufgebaut hat User 2 Verloren und User 1 Gewinnt 
            //Am Ende soll eine weitere Spielrunde angeboten werden.
            Console.WriteLine("Lets Play Hangman!");
            string[] words = new string[10];
            words[0] = "Wort";
            words[1] = "Affe";
            words[2] = "Haus";
            words[3] = "Spain";
            words[4] = "Birne";
            words[5] = "Geld";
            words[6] = "Winter";
            words[7] = "Auto";
            words[8] = "Blume";
            words[9] = "Zoo";
            Random genRand = new Random();
            var i = genRand.Next(0, 9);
            string mysteryWord = words[i];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");

            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';

            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
            }
        }
    }
}
           
      

