using System;
using System.Collections.Generic;

namespace weakestLink
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert N:");
            int n = Convert.ToInt32(Console.ReadLine());
            List <int> players = new List <int> ();
            for (int i = 0; i < n; i++)
                players.Add(i);
            int round = 1;
            Console.WriteLine("Insert player position to remove:");
            int pos = Convert.ToInt32(Console.ReadLine());
            while (players.Count > 1 && pos <= players.Count)
            {
                players.RemoveAt(pos - 1);
                Console.WriteLine($"Round {round}. Player removed. People to remove: {players.Count}.");
                round++;
            }
            Console.WriteLine("Game over. Impossible to remove.");
        }
    }
}
