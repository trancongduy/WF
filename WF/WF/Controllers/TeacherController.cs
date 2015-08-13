using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WF.Model.DAL;
namespace WF.Controllers
{
    public class TeacherController : ApiController
    {
        private WFContext _dbContext;
        private WFContext DbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new WFContext();
                }
                return _dbContext;
            }
        }

    }
}