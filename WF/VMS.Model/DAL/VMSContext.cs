using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Model.DiscussionModel;
using VMS.Model.TeacherModel;

namespace VMS.Model.DAL
{
    public class VMSContext : DbContext,IVMSContext
    {
        public VMSContext()
            : base("VMSConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
            //can config validate model here.
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Topic> Topics { get; set; }

        void IVMSContext.SetState(object item, EntityState state)
        {
            Entry(item).State = state;
        }

    }
}
