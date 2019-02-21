using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Crud_Api;

namespace Crud_Api.Controllers
{
    public class InternsController : ApiController
    {
        private SampleDBEntities db = new SampleDBEntities();

        // GET: api/Interns
        public IQueryable<Intern> GetInterns()
        {
            return db.Interns;
        }

        // GET: api/Interns/5
        [ResponseType(typeof(Intern))]
        public IHttpActionResult GetIntern(int id)
        {
            Intern intern = db.Interns.Find(id);
            if (intern == null)
            {
                return NotFound();
            }

            return Ok(intern);
        }

        // PUT: api/Interns/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIntern(int id, Intern intern)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != intern.Id)
            {
                return BadRequest();
            }

            db.Entry(intern).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InternExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Interns
        [ResponseType(typeof(Intern))]
        public IHttpActionResult PostIntern(Intern intern)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Interns.Add(intern);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (InternExists(intern.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = intern.Id }, intern);
        }

        // DELETE: api/Interns/5
        [ResponseType(typeof(Intern))]
        public IHttpActionResult DeleteIntern(int id)
        {
            Intern intern = db.Interns.Find(id);
            if (intern == null)
            {
                return NotFound();
            }

            db.Interns.Remove(intern);
            db.SaveChanges();

            return Ok(intern);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InternExists(int id)
        {
            return db.Interns.Count(e => e.Id == id) > 0;
        }
    }
}