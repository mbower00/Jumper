// Keeps track of how much damage the chute has taken, and how much of the word they have guessed

using System;

namespace cse210_jumper.game{
    public class Jumper{
        private int chuteDamage = 0;
        private List<string> currentStatus = new List[];
        
        private void setCurrentStatus(){  // letters in Current status = underlines
            currentStatus = Puzzle.LettersNeeded;
            // for i in currentStatus{
                // currentStatus[i] = "_"
            // }
            
            
        }
        public Jumper() // Is consturctor
        {

        }
        private bool interpretGuess(){  // Compares secret word to input
            // int temp = Puzzle.GetGuesses();
            // currentStatus[temp] = Director.playerGuess

            /*
            Search Puzzle.LettersNeeded against Director.playerGuess
            if Director.playerGuess == Puzzle.LettersNeeded {
                return True
            }
            else{
                return False 
            }
            */
        } 
        public void updateStatus(){  // Determines if input and secret code match  --  changes damage
            // if interpretGuess == true{
                // change currentStaus to Letters
            // }
            // else{
                // chuteDamage +=;
            // }
            Puzzle.LettersNeeded;
            Director.playerGuess;
        } 
        public int getChuteDamage(){  // return damage level
            chuteDamage;
        } 
        public list getStatus(){  // contains data of the Underscores and Letters
            currentStatus;
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