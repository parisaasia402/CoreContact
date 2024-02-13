using CoreContact.Core.Service.Interface;
using CoreContact.DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreContact.Controllers
{
    public class ContactController : Controller
    {

        private IContactService _contactService;
            public ContactController(IContactService contactService)

            {
                _contactService = contactService;
            }

            public IActionResult Index()
            {
                return View(_contactService.ShowAllContact());
            }
           [HttpGet]
            public IActionResult AddContact()
            {
                return View();
            }
            [HttpPost]
            public IActionResult AddContact(Contact contact)
            {
                if (!ModelState.IsValid)
                    return View(contact);

                int result = _contactService.AddContact(contact);
                TempData["result"] = result > 0 ? "true" : "false";
               
                return RedirectToAction("Index");


            }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            return View(_contactService.FindContactByID(id));
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            if (!ModelState.IsValid)
                return View(contact);
            bool result = _contactService.UpdateContact(contact);
            TempData["result"] = result ? "true" : "false";
            return RedirectToAction("Index");

        }
        }
    }

