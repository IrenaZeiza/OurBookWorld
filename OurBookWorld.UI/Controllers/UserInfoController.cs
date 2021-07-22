    using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurBookWorld.UI.Controllers
{
    public class UserInfoController : Controller
    {
        public IActionResult UserContacts()
        {
            return View();
        }

    }
}
