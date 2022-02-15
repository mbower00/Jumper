using System;

//director class
//Object Director
//Responsibility (what it does): 
//Receives input from user for the different aspects of the game, controls game flow
//Behaviors (Methods):
//Receive an answer to play again?
//Receives input for guesses
//Updates wins and losses
//Start game
//Sends guess
//Same guess
//States (Attributes):
//Play again choice: string
//Play again: bool
//guess : string

//Class Director
//Attributes:
//continuePlayChoice: string
//playerGuess: char
//gameEnding: bool
//Methods:  dws
//ContinuePlay(): bool
//NewGuess(): string
//GameOutcome(): bool
//StartGame(): void
//IsSameGuess: bool
/// <summary>
/// 
/// </summary>
namespace cse210_jumper.game{
    public class Director{
        
        private char playerGuess = '0';
        private Jumper jumper = new Jumper();
        private bool keepPlaying = true; 
        private Puzzle puzzle = new Puzzle();
        private Terminal terminal = new Terminal();
        private bool isGaming;
        private string playerContinueResponse;


        public void StartGame()
      {
        while(keepPlaying){ ///here we loop the whole game itself, after the conclusion of each game it'll ask if they'd like to play again
            jumper.SetNewJumper(puzzle);
            isGaming = true;
            while(isGaming){ /// here we loop the steps of the game with the functions we have called from the other classes and functions we have written
                GetInputs();
                puzzle.GetGuesses(playerGuess);
                DoUpdates();
                DoOutputs();
            }
            ContinueGame();
        }
      /// <summary>
      /// Constructor
      /// </summary>    
      }
        public Director(){

        }
        
        public void GetInputs(){ /// showing the user the promts written in the terminal class and calling them here
            terminal.DisplayPrompt();
            playerGuess = char.Parse(Console.ReadLine());
            

        }
        private void DoUpdates() /// We want to show the user the jumper that is being updated every loop and its surroundings
        /// like the ground or the blanks of letters
        {
            jumper.SetCurrentStatus(playerGuess, puzzle);
            terminal.DisplayStatus(jumper);
            terminal.DisplayScene(jumper);
        }
        private void DoOutputs(){ /// Now we are goning to get the information needed to call the game, if the chute is damaged 5 times they lose the game while
                /// if all the "_" are removed before that they win the game
            
                if (jumper.GetChuteDamage() == 5) /// call from jumper to get the damage and checking to see if the player has exceded 5 yet
                {
                    terminal.DisplayLose(); /// displays the loss function called from terminal
                    isGaming = false;
                } 
                else if (!jumper.GetStatus().Contains('_')){ /// now we pull from jumper to see if the blanks are gone
                    terminal.DisplayWin();  /// displays the win function called from terminal
                    isGaming = false;
                }
            
            }  


    
        private void ContinueGame() /// Here we get our answer to the prompt if they want to play again and if they do then the game loops or breaks the code.
        {
            terminal.DisplayContinue();
            playerContinueResponse = Console.ReadLine();
            if(playerContinueResponse == "y"){
                keepPlaying = true;
            }
            else if(playerContinueResponse == "n"){
                keepPlaying = false;
            }
        }
    
     
//string keepPlaying = Console.ReadLine(); // gets input and applys it to keepPlaying
            //isPlaying = (keepPlaying == "y");
            //Console.WriteLine(""); // print blank line
        






    }
}
     
   
   





