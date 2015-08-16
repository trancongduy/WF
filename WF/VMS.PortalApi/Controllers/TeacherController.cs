using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VMS.Model.DAL;
using VMS.Model.TeacherModel;
namespace VMS.PortalApi.Controllers
{
    public class TeacherController : ApiController
    {
        private IVMSContext db;
        public TeacherController()
        {
            db = new VMSContext();
        }
        public TeacherController(IVMSContext context)
        {
            db = context;
        }

        [HttpGet]
        public IHttpActionResult GetTeachers()
        {
            return Ok(db.Teachers);
        }

        [HttpGet]
        public IHttpActionResult FindTeacherByID(int id)
        {
            return Ok(db.Teachers.SingleOrDefault(n => n.ID == id));
        }

        [HttpPost]
        public IHttpActionResult AddTeacher(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var addteacher = db.Teachers.Add(teacher);
            db.SaveChanges();
            return CreatedAtRoute("ActionApi", new { action = "FindTeacherByID", id = addteacher.ID }, teacher);
        }
        //test branch
    }
}