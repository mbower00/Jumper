using System;

    ///Holds a list of words to randomly pull words from, holds the pulled word, 
    ///and determines if the guess is correct or not
    public class Puzzle{

        Random random = new Random();
        List<char> wordLetters = new List<char>();

        public Puzzle()
        {

        }

        /// <summary>
        /// Holds a list of words to be pulled from
        /// </summary>
        /// <returns>one word to be played with</returns>
        public string WordList()
        {

            List<string> wordBank = new List<string>();  
            wordBank.Add("imminent");  
            wordBank.Add("giant"); 
            wordBank.Add("glitter"); 
            wordBank.Add("clothes"); 
            wordBank.Add("soccer"); 
            wordBank.Add("thunder"); 
            wordBank.Add("lightning"); 
            wordBank.Add("train"); 
            wordBank.Add("bike");         
            int newWord = random.Next(wordBank.Count);
            return wordBank[newWord];
            
        }

        /// <summary>
        /// Takes word from WordList and turns it into a list of characters
        /// </summary>
        /// <param name="newWord"></param>
        /// <returns>list of characters made from the word</returns>
        public List<char> LettersNeeded()
        {
            

            for (int i = 0; i < newWord.Length; i++)
            {
                wordLetters.Add(newWord[i]);
                Console.WriteLine(wordLetters[i]);
            }
            
            return wordLetters;

        }

        /// <summary>
        /// Compares the player's guess to the word used to see if the letter 
        /// they guess is in the word
        /// </summary>
        /// <param name="wordLetters"></param>
        /// <returns>the index number(s) of the letter guess if correct</returns>
        public List<int> GetGuesses(playerGuess)
        {
            public string lettersGuessed = playerGuess;
            int letNum = (int) lettersGuessed % 32;
            List<int> correctGuess = new List<int>();

            for (int i = 0; i < wordLetters.Count; i++ )
             {
                if (letNum == (int) wordLetters[i] % 32)
                {
                    Console.WriteLine(i);
                    correctGuess.Add(i);
                    Console.WriteLine(correctGuess);

                }
                 
                else
                {
                    correctGuess.Add(-1);
                }
             }
             return correctGuess;

        }

    }
