﻿namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO SNAKE AND LADDER Game");
            SnakeAndLadder playerOne = new SnakeAndLadder();
            playerOne.DieRolling();
            Console.WriteLine(playerOne.DieRolling());
        }
    }
}