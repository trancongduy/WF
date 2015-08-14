using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.Model.TeacherModel;

namespace WF.Model.DAL
{
    public class VMSContext : DbContext
    {
        public VMSContext()
            : base("VMSConnection")
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
