using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository db;
        public ContactController(IContactRepository db)
        {
            this.db = db;
        }
        Models.Contact c;
        readonly List<Models.Contact> contactList = new List<Models.Contact>();
        // GET: Contact
        public ActionResult Index()
        {   
            var contacts=db.GetContacts();
            foreach (var contact in contacts)
            {
                c = new Models.Contact();
                c.Name = contact.GetName(contact.FirstName, contact.MiddleName, contact.LastName);
                c.Mobile = contact.Mobile;
                c.HomePhone = contact.HomePhone;
                c.Num++;
                c.Email = contact.Email;
                c.Id = contact.Id;
                contactList.Add(c);
            }
            
            return View(contactList);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            var contact=db.GetContactById(id);
            c = new Models.Contact();
            c.Id = contact.Id;
            c.Name = contact.GetName(contact.FirstName, contact.MiddleName, contact.LastName);
            c.Mobile = contact.Mobile;
            c.HomePhone = contact.HomePhone;
            c.WorkPhone = contact.WorkPhone;
            c.Email = contact.Email;
            return View(c);
        }
        // GET: Contact/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Models.Contact contact)
        {
            Domain.Contact dmc = new Contact();
            dmc.FirstName = contact.FirstName;
            dmc.MiddleName = contact.MiddleName;
            dmc.LastName = contact.LastName;
            dmc.Mobile = contact.Mobile;
            dmc.WorkPhone = contact.WorkPhone;
            dmc.HomePhone = contact.HomePhone;
            dmc.Email = contact.Email;

            try
            {
                db.Add(dmc);
                db.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contact/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }   
            catch
            {
                return View();
            }
        }
    }
}