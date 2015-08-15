namespace VMS.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VMS.Model.TeacherModel;

    internal sealed class Configuration : DbMigrationsConfiguration<VMS.Model.DAL.VMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VMS.Model.DAL.VMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            context.Teachers.AddOrUpdate(t => t.Email, new Teacher { Email = "duy.tran.k1set@eiu.edu.vn", FirstName = "Duy", LastName = "Tran Cong", PhoneNumber = "01262502179" });
            context.SaveChanges();
        }
    }
}
