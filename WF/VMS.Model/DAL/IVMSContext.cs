using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Model.DiscussionModel;
using VMS.Model.TeacherModel;

namespace VMS.Model.DAL
{
    public interface IVMSContext : IDisposable
    {
        DbSet<Comment> Comments { get; set; }
        DbSet<Topic> Topics { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        int SaveChanges();
        void SetState(object item, EntityState state);
    }
}
