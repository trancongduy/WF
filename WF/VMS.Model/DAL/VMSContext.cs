using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //can config validate model here.
        }

        public DbSet<Teacher> Teachers { get; set; }

        void IVMSContext.SetState(object item, EntityState state)
        {
            Entry(item).State = state;
        }

    }
}
