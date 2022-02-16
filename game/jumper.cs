// Keeps track of how much damage the chute has taken, and how much of the word they have guessed

using System;

namespace cse210_jumper.game{
    public class Jumper{
        private int chuteDamage = 0;
        private List<char> currentStatus = new List<char>();
        Puzzle puzzle = new Puzzle();
        private string newWord = ""; 
        private List<char> chars = new List<char>();
        private List<int> correctIndexes = new List<int>();
        private bool isCorrectGuess;
// ----------------------------------------------------------------------------------------------------------
        
        
        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public Jumper(){
        }


        /// <summary>
        /// Converts a new word to underscores, sets damage to 0
        /// </summary>
        public void SetNewJumper(Puzzle puzzle){
            newWord = puzzle.WordList();
            chars = puzzle.LettersNeeded(newWord);
            for (int i = 0; i < chars.Count; i++){
                currentStatus.Add('_');
            }
            chuteDamage = 0;
        }


        /// <summary>
        /// Converts proper underscores to letter, or deals damage
        /// </summary>
        /// <param name="guess">Player's guess</param>
        /// <param name="puzzle">puzzle instance from director</param>
        public void SetCurrentStatus(char guess, Puzzle puzzle){  // letters in Current status = underlines
            correctIndexes = puzzle.GetGuesses(guess);
            isCorrectGuess = false;
            for (int i = 0; i < correctIndexes.Count; i++ ){
                if (correctIndexes[i] != -1){
                    currentStatus[i] = guess;
                    isCorrectGuess = true;
                }
            }
            if (!isCorrectGuess){
                chuteDamage ++;
            }
        }


        /// <summary>
        /// Returns damage
        /// </summary>
        public int GetChuteDamage(){  // return damage level
            return chuteDamage;
        } 


        /// <summary>
        /// Returns mix of Underscores and guessed letters
        /// </summary>
        public List<char> GetStatus(){  // contains data of the Underscores and Letters
            return currentStatus;
        } 
    }
}



/*
Attributes:
    chuteDamage: int
    currentStatus: string
Methods:
    InterpretGuess(): bool
    UpdateStatus(): void
    GetChuteDamage(): int
    GetStatus(): list
*/
// ------------------------------------------------------------
/*
Behaviors (Methods):
    Changes underscore to correctly guessed letters
    Send game status
    Receives the correct/incorrect guess
    Interprets the guess based off received secret letters
    Updates status
    Send chute damage to terminal service
States (Attributes):
    Chute damage: int
    Status: string
*/