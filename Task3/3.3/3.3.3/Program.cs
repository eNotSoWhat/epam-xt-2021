using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Program
    {
        static Pizzeria pizzeria = new Pizzeria();
        static int id = 0;
        public static void Display(int id, Pizza[] pizza)
        {
            foreach (var i in pizza)
            {
                Console.WriteLine(i.name + ' ');
            }
            Console.WriteLine($"Pizza is ready - id {id}.");
        }
        public static void Customer(int id)
        {
            List<Pizza> pizza = new List<Pizza>();
            Console.WriteLine("What would you like?");
            int.TryParse(Console.ReadLine(), out int num);
            Pizza choice = pizzeria.menu[num];
            pizza.Add(choice);
            pizzeria.Queue(id, choice);
        }
        static void Main()
        {
            id++;
            Customer(id);
        }
    }
}
