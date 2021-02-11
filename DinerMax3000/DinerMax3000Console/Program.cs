using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;
namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> menusFromDatabase = Menu.GetAllMenus();
            Menu firstMenuItem = menusFromDatabase[0];
            firstMenuItem.SaveNewMenuItem("Nesto", "Opis neceg", 10);
            menusFromDatabase = Menu.GetAllMenus();

            Order hungryGuest = new Order();
            foreach(Menu currentMenu in menusFromDatabase)
            {
                foreach (MenuItem currentItem in currentMenu.items)
                {
                    hungryGuest.items.Add(currentItem);
                }
            }
          

            Console.WriteLine("The total is: " + hungryGuest.Total);
            //try
            //{
            //    outsideDrinks.AddMenuItem("Water", "All natural", 0);
            //}
            //catch(Exception thrownException)
            //{
            //    Console.WriteLine(thrownException.Message);
            //}

            Console.ReadKey();
        }
    }
}
