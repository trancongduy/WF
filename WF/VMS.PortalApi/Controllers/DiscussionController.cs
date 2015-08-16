using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using VMS.Model.DAL;

namespace VMS.WebApi.Controllers
{
    public class DiscussionController : ApiController
    {
        private IVMSContext db;
        public DiscussionController()
        {
            db = new VMSContext();
        }
        public DiscussionController(IVMSContext context)
        {
            db = context;
        }

        [HttpGet]
        public IHttpActionResult GetComments()
        {
            return Ok(db.Comments.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
                db = null;
            }
            base.Dispose(disposing);
        }
    }
}
