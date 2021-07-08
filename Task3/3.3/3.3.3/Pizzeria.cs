using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class Pizzeria
    {
        public Dictionary<int, Pizza> menu = new Dictionary<int, Pizza>()
        {
            {1, new Pizza ("Treasure Island", 654) },
            {2, new Pizza ("Volga", 582) },
            {3, new Pizza ("Captain's", 582) }
        };
        public void Menu()
        {
            foreach(var i in menu)
            {
                Console.WriteLine(i.Key + ") " + i.Value.name + " - " + i.Value.price);
            }
        }
        public Action<int, Pizza[]> Order;
        public void Queue(int id, Pizza[] pizza)
        {
            Task.Factory.StartNew(() =>
            {
                Order(id, pizza);
            });
        }
    }
}
