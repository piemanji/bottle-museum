using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BottleMuseum.Website.Controllers
{
    public class BottleController : Controller
    {
        public string Index()
        {
            return "Bottle";
        }
    }
}