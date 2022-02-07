using System;

namespace cse210_jumper.game{

    ///Holds a list of words to randomly pull words from, holds the pulled word, 
    ///and determines if the guess is correct or not
    public class Puzzle{

        Random random = new Random();

        public Puzzle()
        {

        }

        public string WordList()
        {

            private List<string> wordBank = File.ReadAllLines("words.txt").ToList();
            string newWord = random.next(wordBank.count);
            return newWord;
            
        }

        public string LettersNeeded()
        {
            private List<string> wordLetters = new List<string>();
            


        }

        public string GetGuesses()
        {
            public string lettersGuessed = Director.playerGuess();

        }

    }
}