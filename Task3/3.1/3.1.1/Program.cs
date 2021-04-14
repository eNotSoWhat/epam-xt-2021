using System;
using System.Collections.Generic;

namespace weakestLink
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите N:");
            int n = Convert.ToInt32(Console.ReadLine());
            List <int> players = new List <int> ();
            for (int i = 0; i < n; i++)
                players.Add(i);
            int round = 1;
            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд:");
            int pos = Convert.ToInt32(Console.ReadLine());
            while (players.Count > 1 && pos <= players.Count)
            {
                players.RemoveAt(pos - 1);
                Console.WriteLine($"Раунд {round}. Вычеркнут человек. Людей осталось: {players.Count}");
                round++;
            }
            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей");
        }
    }
}
