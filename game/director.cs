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
        private Jumper jumper = new Jumper();
        private bool keepPlaying = true;
        private Puzzle puzzle = new Puzzle();
        private terminal terminal = new terminal();
        public void StartGame()
      {
          while(keepPlaying){
              while(true){
              GetInputs();
              DoUpdates();
              DoOutputs();
            }
            ContinueGame();
          }
          


      }
        
        
        private void GetInputs(){
            terminal.DisplayPrompt()
            

        }
        private void DoUpdates()
        {

            terminal.DisplayStatus(jumper)
            terminal.DisplayScene(jumper)
        }
        private void DoOutputs(){
            
                else if (jumper.GetChuteDamage() == 5)
                {
                    terminal.DisplayLose()
                    break;
                } 
                if !(jumper.GetStatus().Contains("_")){
                    terminal.DisplayWin()
                    break;
                }
            
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
     
   
   





