// Keeps track of how much damage the chute has taken, and how much of the word they have guessed

using System;

namespace cse210_jumper.game{
    public class Jumper{
        private int chuteDamage;
        private List<string> currentStatus = new List[];
        
        private bool interpretGuess(); // Compares secret word to input
        public void updateStatus(); // Determines if input and secret code match  --  changes damage
        public int getChuteDamage(); // return damage level
        public list getStatus(); // contains data of the Underscores and Letters
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