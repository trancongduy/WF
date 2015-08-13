using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.Model.TeacherModel;

namespace WF.Model.DAL
{
    class WFContext : DbContext
    {
        public WFContext()
            : base("DefaultConnection")
        {

        }
        DbSet<Teacher> Accounts { get; set; }
    }
}
