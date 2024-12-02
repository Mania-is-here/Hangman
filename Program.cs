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
            /*Console.WriteLine("Lets Play Hangman!");
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
                Console.WriteLine(guess);*/
            Console.WriteLine("User please enter a word");
            string word = Console.ReadLine();
            List<char> guessedLetters = new List<char>();

            int maxLives = 7;
            int currentLives = maxLives;

            bool win = false;

            while (currentLives > 0 && !win)
            {
                foreach (char c in word)
                {
                    if (guessedLetters.Contains(c))
                        Console.Write(c);
                    else
                        Console.Write('_');
                }

                Console.WriteLine("\nPlease guess a letter!");
                Console.WriteLine(currentLives + "/" + maxLives + " lives remaining.");

                char guess = Convert.ToChar(Console.ReadLine());

                if (word.Contains(guess) && !guessedLetters.Contains(guess))
                {
                    Console.WriteLine("Correct!");
                    guessedLetters.Add(guess);
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    currentLives--;
                }

                bool wordComplete = true;
                foreach (char c in word)
                    if (!guessedLetters.Contains(c))
                        wordComplete = false;

                win = wordComplete;
            }

            if (win)
                Console.WriteLine("Congratulations, you win!");
            else
                Console.WriteLine("You lose...");
        }
        }
    }

           
      

