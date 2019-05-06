using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vizew.WebUI.Models;
using Vizew.WebUI.Models.Entity;

namespace Vizew.WebUI.Controllers
{
 

    public class ContactController : Controller
    {
        VizewDbContext db = new VizewDbContext();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name,string Email,string Message)
        {
            Contact contact = new Contact();
            contact.Name = Name;
            contact.Email = Email;
            contact.Message = Message;
            db.Contact.Add(contact);
            db.SaveChanges();
        

            return Json(contact, JsonRequestBehavior.AllowGet);
        }


    }
}