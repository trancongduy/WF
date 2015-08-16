
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Model.DAL;
using VMS.Model.DiscussionModel;
using VMS.Model.TeacherModel;
using VMS.WebApiTest.Model;

namespace VMS.Test.WebApiTest.Model
{
    public class FakeContext : IVMSContext
    {
        public FakeContext() {
            Teachers = new TestDbSet<Teacher>();
            Comments = new TestDbSet<Comment>();
            Topics = new TestDbSet<Topic>();
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public int SaveChanges()
        {
            return 0;
        }
        public void SetState(object item,EntityState state)
        {
        }

        public void Dispose()
        {
        }
    }
}
