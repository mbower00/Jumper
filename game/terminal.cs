// Text color changing source: https://www.c-sharpcorner.com/article/change-console-foreground-and-background-color-in-c-sharp/
using System;

namespace cse210_jumper.game{

    /// <summary>
    /// Displays information for the user to interact with
    /// </summary>
    public class Terminal{
        private string turnPrompt = "Guess a letter [a-z]: ";
        private string continuePrompt = "Would you like to play again? [y/n] ";
        private string ground = "^^^^^^^";
        private string liveJumper = "  0 \n/|\\ \n/ \\";
        private string deadJumper = "  x \n/|\\ \n/ \\";
        private string hasLoser = "You missed too many guesses! You lose!";
        private string winnerPrompt = "You guess the word! Great job, you win!";
        private string chuteLayer01 = " ___";
        private string chuteLayer02 = "/   \\";
        private string chuteLayer03 = "=====";
        private string chuteLayer04 = "\\   /";
        private string chuteLayer05 = " \\ /";


        /// <summary>
        /// Constructor
        /// </summary>
        public Terminal(){

        }

        /// <summary>
        /// Displays the prompt for the user to guess the letter and a blank line
        /// </summary>
        public void DisplayPrompt(){
            Console.WriteLine(turnPrompt);
            Console.WriteLine("");
        }

        /// <summary>
        /// Recives the status from Jumper and prints out the status (letters in green and underscores in red) and a blank line
        /// </summary>
        public void DisplayStatus(){
            foreach (string i in jumper.GetStatus()){
                if (i == "_"){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i);
                    Console.ForegroundColor = ConsoleColor.White; //set back to white
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(i);
                    Console.ForegroundColor = ConsoleColor.White; //set back to white
                }
                Console.Write(" ");
            }
            Console.Writeline("");
            Console.Writeline("");
        }

        /// <summary>
        /// Recieves the chute damage from Jumper and prints the scene (with current chute (magenta in color), living/dead jumper (cyan in color), the ground (dark green in color), and a blank line)
        /// </summary>
        public void DisplayScene(){
            if (jumper.GetChuteDamage() == 0){
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(chuteLayer01);
                Console.WriteLine(chuteLayer02);
                Console.WriteLine(chuteLayer03);
                Console.WriteLine(chuteLayer04);
                Console.WriteLine(chuteLayer05);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(liveJumper);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(ground);
                Console.ForegroundColor = ConsoleColor.White; //set back to white
            }
            else if (jumper.GetChuteDamage() == 1){
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(chuteLayer02);
                Console.WriteLine(chuteLayer03);
                Console.WriteLine(chuteLayer04);
                Console.WriteLine(chuteLayer05);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(liveJumper);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(ground);
                Console.ForegroundColor = ConsoleColor.White; //set back to white
            }
            else if (jumper.GetChuteDamage() == 2){
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(chuteLayer03);
                Console.WriteLine(chuteLayer04);
                Console.WriteLine(chuteLayer05);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(liveJumper);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(ground);
                Console.ForegroundColor = ConsoleColor.White; //set back to white
            }
            else if (jumper.GetChuteDamage() == 3){
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(chuteLayer04);
                Console.WriteLine(chuteLayer05);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(liveJumper);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(ground);
                Console.ForegroundColor = ConsoleColor.White; //set back to white
            }
            else if (jumper.GetChuteDamage() == 4){
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(chuteLayer05);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(liveJumper);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(ground);
                Console.ForegroundColor = ConsoleColor.White; //set back to white
            }
            else if (jumper.GetChuteDamage() == 5){
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(deadJumper);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(ground);
                Console.ForegroundColor = ConsoleColor.White; //set back to white
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Displays the win text in green
        /// </summary>
        public void DisplayWin(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Writeline(winnerPrompt);
            Console.ForegroundColor = ConsoleColor.White; //set back to white
        }

        /// <summary>
        /// Displays the lose text in red
        /// </summary>
        public void DisplayLose(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Writeline(hasLoser);
            Console.ForegroundColor = ConsoleColor.White; //set back to white
        }

        /// <summary>
        /// Displays the play again (aka continue) prompt text
        /// </summary>
        public void DisplayContinue(){
            Console.Writeline(continuePrompt);
        }
    }
}