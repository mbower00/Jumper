using System;



    ///Holds a list of words to randomly pull words from, holds the pulled word, 
    ///and determines if the guess is correct or not
    public class Puzzle{

        Random random = new Random();

        public Puzzle()
        {

        }
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
            Console.WriteLine(wordBank[newWord]);
            return wordBank[newWord];
            
        }

        public List<char> LettersNeeded(string newWord)
        {
            List<char> wordLetters = new List<char>();

            for (int i = 0; i < newWord.Length; i++)
            {
                wordLetters.Add(newWord[i]);
                Console.WriteLine(wordLetters[i]);
            }
            
            return wordLetters;

        }

        public List<int> GetGuesses(List<char> wordLetters)
        {
            
            
            public string lettersGuessed = Director.GetInputs();
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
