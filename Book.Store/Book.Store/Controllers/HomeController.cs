using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Store.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Tannu Verma";
        }
    }
}
