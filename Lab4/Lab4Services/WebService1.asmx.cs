using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab4Services
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public float CelsiusToFahrenheit(float celcius)
        {
            return celcius * 9 / 5 + 32;
        }

        [WebMethod]
        public float FahrenheitToCelsius(float fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        [WebMethod]
        public string CurrentDateAndTime()
        {
            // return the current date and time
            return DateTime.Now.ToString();
        }

        [WebMethod]
        public string[] GetShoppingList()
        {
            string[] shoppingList = { "Milk", "Bread", "Eggs", "Butter", "Cheese" };
            return shoppingList;
        }

        [WebMethod]
        public float EuroToRon(float euro)
        {
            return euro * 4.93f;
        }

        [WebMethod]
        public float RonToEuro(float ron)
        {
            return ron / 4.93f;
        }
    }
}
