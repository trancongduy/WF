using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VMS.Model.DAL;
using VMS.Model.TeacherModel;
namespace VMS.Controllers
{
    public class TeacherController : ApiController
    {
        private VMSContext _dbContext;
        private VMSContext DbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new VMSContext();
                }
                return _dbContext;
            }
        }

        [HttpGet]
        public IHttpActionResult GetTeachers()
        {
            return Ok(DbContext.Teachers);
        }

        [HttpGet]
        public IHttpActionResult FindTeacherByID(int id)
        {
            return Ok(DbContext.Teachers.SingleOrDefault(n => n.ID == id));
        }

        [HttpPost]
        public IHttpActionResult AddTeacher(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var addteacher = DbContext.Teachers.Add(teacher);
            DbContext.SaveChanges();
            return CreatedAtRoute("ActionApi", new { action = "FindTeacherByID", id = addteacher.ID }, teacher);
        }
    }
}