using System;

namespace cse210_jumper
{
    /// <summary>
    /// Program class: creates instance of Director and starts game.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}