using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Domain;
using Microsoft.AspNetCore.Authorization;

namespace todoapivstemplate.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        // GET: api/Contact
        [HttpGet]
        public ActionResult<IEnumerable<Domain.ContactUser>> GetContactUser()
        {
            return  _contactRepository.GetContactUsers().ToList();
        }

        // GET: api/Contact/5
        /*[HttpGet("{id}")]
           public async Task<ActionResult<ContactUser>> GetContactUser(int id)
           {
               var contactUser = await _contactRepository.ContactUser.FindAsync(id);

               if (contactUser == null)
               {
                   return NotFound();
               }

               return contactUser;
           }

           // PUT: api/Contact/5
           [HttpPut("{id}")]
           public async Task<IActionResult> PutContactUser(int id, ContactUser contactUser)
           {
               if (id != contactUser.Id)
               {
                   return BadRequest();
               }

               _contactRepository.Entry(contactUser).State = EntityState.Modified;

               try
               {
                   await _contactRepository.SaveChangesAsync();
               }
               catch (DbUpdateConcurrencyException)
               {
                   if (!ContactUserExists(id))
                   {
                       return NotFound();
                   }
                   else
                   {
                       throw;
                   }
               }

               return NoContent();
           }

           // POST: api/Contact
           [HttpPost]
           public async Task<ActionResult<ContactUser>> PostContactUser(ContactUser contactUser)
           {
               _contactRepository.ContactUser.Add(contactUser);
               await _contactRepository.SaveChangesAsync();

               return CreatedAtAction("GetContactUser", new { id = contactUser.Id }, contactUser);
           }

           // DELETE: api/Contact/5
           [HttpDelete("{id}")]
           public async Task<ActionResult<ContactUser>> DeleteContactUser(int id)
           {
               var contactUser = await _contactRepository.ContactUser.FindAsync(id);
               if (contactUser == null)
               {
                   return NotFound();
               }

               _contactRepository.ContactUser.Remove(contactUser);
               await _contactRepository.SaveChangesAsync();

               return contactUser;
           }

           private bool ContactUserExists(int id)
           {
               return _contactRepository.ContactUser.Any(e => e.Id == id);
           }*/
    }
}
