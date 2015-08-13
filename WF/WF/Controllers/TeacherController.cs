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
        private WFContext db
        {
            get
            {
                if (_backupsetDbSet == null)
                {
                    _backupsetDbSet = new BackupSetContext();
                }
                return _backupsetDbSet;
            }
        }

    }
}