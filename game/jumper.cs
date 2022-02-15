// Keeps track of how much damage the chute has taken, and how much of the word they have guessed

using System;

namespace cse210_jumper.game{
    public class Jumper{
        private int chuteDamage = 0;
        private List<char> currentStatus = new List[];
// ----------------------------------------------------------------------------------------------------------
        
        
        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public Jumper(){
        }


        /// <summary>
        /// Constructor that recieves a list of chars.  If this constructor is called, you do not need to call setNewJumper().
        /// </summary>
        public Jumper(list<char> chars){
            setNewJumper(chars);
        }


        /// <summary>
        /// Converts a new word to underscores, sets damage to 0
        /// </summary>
        public void setNewJumper(list<char> chars){
            int x = 0;
            foreach(char c in chars ){
                currentStatus[x] = '_';
                x++;
            }
            chuteDamage = 0;
        }


        /// <summary>
        /// Converts Underscore to letter, or deals damage
        /// </summary>
        private void setCurrentStatus(char guess, int pos){  // letters in Current status = underlines
            if (pos != -1){
                currentStsus[pos] = guess;
            }      
            else{
                chuteDamage++;
            }
        }


        /// <summary>
        /// Returns damage
        /// </summary>
        public int getChuteDamage(){  // return damage level
            return chuteDamage;
        } 


        /// <summary>
        /// Returns mix of Underscores and guessed letters
        /// </summary>
        public list<char> getStatus(){  // contains data of the Underscores and Letters
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