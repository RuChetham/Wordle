﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    internal class Word
    {
        private string guess;
        public Word(string word)
        {
            this.guess = word;
        }

        public void OutputGuess(string correct)
        {
            if (this.guess == String.Empty || this.guess.Length != correct.Length)
            {
                Console.SetCursorPosition(0, Console.CursorTop + 1);
            }
            else
            {
                for (int i = 0; i < correct.Length; i++)
                {
                    bool contains = correct.Contains(guess[i]);

                    ConsoleColor colour = (this.guess[i] == correct[i])
                        ? ConsoleColor.Green
                        : contains
                        ? ConsoleColor.Yellow
                        : ConsoleColor.Red;

                    Console.ForegroundColor = colour;
                    Console.Write(guess[i]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
