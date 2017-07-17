using Microsoft.AspNetCore.Mvc;

namespace BottleMuseum.Website.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome to the Aughton Bottle Museum";
        }

        public string ContactUs(string contactMethod)
        {
            switch (contactMethod)
            {
                case "PhoneNumber":
                    return "01142873835";
                case "Email":
                    return "ben_jones-1995@hotmail.co.uk";
                case "PostalAddress":
                    return "46 Main Street, Aughton S26 3XJ";
            }

            return "try again";
        }

        public string Bottle(int id, int number)
        {
            switch (id)
            {
                case 0:
                    return number + " bottles of DoomBar";
                case 1:
                    return number + " bottles of Stella Artois";
            }
            return "Try again!";
        }
    }
}