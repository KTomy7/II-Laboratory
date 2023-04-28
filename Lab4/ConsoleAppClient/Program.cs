using ConsoleAppClient.ServiceReference1;
using System;

namespace ConsoleAppClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient client = new WebService1SoapClient();
            Console.WriteLine("CelsiusToFahrenheit(10) = " + client.CelsiusToFahrenheit(10));
            Console.WriteLine("FahrenheitToCelsius(50) = " + client.FahrenheitToCelsius(50));
            Console.WriteLine("CurrentDateAndTime() = " + client.CurrentDateAndTime());
            Console.WriteLine("EuroToRon(10) = " + client.EuroToRon(10) + " Ron");
            Console.WriteLine("RonToEuro(10) = " + client.RonToEuro(10) + " Euro");
            Console.WriteLine("GetShoppingList() = ");
            string[] shoppingList = client.GetShoppingList().ToArray();
            for (int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine(i+1 + ". " + shoppingList[i]);
            }
            Console.ReadLine();
        }
    }
}
