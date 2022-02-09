using Systems;

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
//playerGuess: string
//gameEnding: bool
//Methods:
//ContinuePlay(): bool
//NewGuess(): string
//GameOutcome(): bool
//StartGame(): void
//IsSameGuess: bool

namespace cse210_jumper.game{
    public class director{
        
        private string playerGuess = "0";
        private bool keepPlaying = true;
        private Puzzle puzzle = new Puzzle();
        private terminal terminal = new terminal();
        public void StartGame()
      {
          while(keepPlaying){
              GetInputs();
              DoUpdates();
              DoOutputs();
          }
          DoOutputs();


      }bing
        
        
        private void GetInputs(){
            terminal.DisplayPrompt()
            

        }
        private void DoUpdates()
        {

        }
        private void DoOutputs(){

            }

    
        private void ContinueGame()
     {
            terminal. DisplayContinue()

        

        }
    
     
//string keepPlaying = Console.ReadLine(); // gets input and applys it to keepPlaying
            //isPlaying = (keepPlaying == "y");
            //Console.WriteLine(""); // print blank line
        






    }
}
     
   
   





