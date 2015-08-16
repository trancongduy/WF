using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Model.TeacherModel;

namespace VMS.Test.WebApiTest.Model
{
    public class TestObject
    {
        public Teacher MyTeacher { get; set; }

        public TestObject() {
            MyTeacher = new Teacher
            {
                Email = "duy.tran.k1set@eiu.edu.vn",
                FirstName = "Duy",
                LastName = "Tran",
                PhoneNumber = "01262502179"
            };
        }
    }
}
