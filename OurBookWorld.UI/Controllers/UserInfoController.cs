    using Microsoft.AspNetCore.Mvc;
using OurBookWorld.UI.Context;
using OurBookWorld.UI.Models;
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

            var user = new UserContactsViewModel();

            user.UserNumber = 11;
            user.Name = "<<...>>";
            user.Surname = "Classic";
            user.Email = "email";

            user.PhoneNumber = 11;

            using (var context = new OurBookWorldDBContext())
            {
                context.Add(user);
                context.SaveChanges();
                var users = context.Users.ToList();
            }

            return View();
        }
        [HttpPost]
        public void SaveUserDetails( int UserNumber, string Name, string Surname, string Email)
        {
            UserContactsViewModel userContacts = new UserContactsViewModel();

            userContacts.UserNumber = UserNumber;
            userContacts.Name = Name;
            userContacts.Surname = Surname;
            userContacts.Email = Email;

            using (var context = new OurBookWorldDBContext())
            {
                context.Add(userContacts);
                context.SaveChanges();

                UserContactsViewModel user = new UserContactsViewModel();
                user = context.Users.FirstOrDefault();
            }

        }

    }
}
