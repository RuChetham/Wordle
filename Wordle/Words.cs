using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle;

namespace Wordle
{
    internal class Words
    {
        private List<Word> attempts = new List<Word>();
        private int maxAttempts;
        private string correct;
        private bool wonGame = false;

        public Words(int attempts, string correct)
        {
            maxAttempts = attempts;
            this.correct = correct.ToUpper();
        }

        public bool MakeAttempt(string attempt)
        {
            if (attempt.Length == correct.Length)
            {
                Word newWord = new(attempt);

                if (attempts.Count != maxAttempts)
                {
                    attempts.Add(newWord);
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public void DisplayAttempt()
        {
            foreach (Word word in attempts)
            {
                if (word.OutputGuess(correct))
                {
                    wonGame = true;
                }
            }
        }

        public bool GameFinished()
        {
            if (this.attempts.Count == maxAttempts || wonGame) // TODO: done
            {
                return true;
            }
            return false;
        }

        public int GetAttempts()
        {
            return attempts.Count;
        }

        public int GetSize()
        {
            return correct.Length;
        }

        public bool GuessedWord()
        {
            return wonGame;
        }
    }
}
