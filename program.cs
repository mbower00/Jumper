using System;
using cse210_jumper.game;

namespace cse210_jumper
{
    /// <summary>
    /// Program class: creates instance of Director and starts game.
    /// </summary>
    class Program
    {
        /// <summary>
        /// creates instance of Director and starts game
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}