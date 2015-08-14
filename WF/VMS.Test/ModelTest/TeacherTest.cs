using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using VMS.Test.Helper;
using System.Collections.Generic;
using VMS.Model.TeacherModel;

namespace VMS.Test.ModelTest
{
    [TestClass]
    public class TeacherTest
    {
        [TestMethod]
        public void Validate_Teacher_Object()
        {
            #region prepare
            var testcases = new[]
            {
                new
                {
                    teacher = new Teacher
                    {
                        Email = "duy.tran.k1set@eiu.edu.vn",
                        FirstName="Duy",
                        LastName="Tran",
                        PhoneNumber="01262502179",
                    },
                    expected = true         
                },
                new
                {
                    teacher = new Teacher
                    {
                        Email = "duy.tran.k1set@gmail.com",
                        FirstName="Duy",
                        LastName="Tran",
                        PhoneNumber="01262502179",
                    },
                    expected = false         
                },      
                 new
                {
                    teacher = new Teacher
                    {
                        FirstName="Duy",
                        LastName="Tran",
                    },
                    expected = false         
                },      
            };
            #endregion
            foreach (var testcase in testcases)
            {
                List<ValidationResult> messageResult;
                var actual = ValidateHelper.ValidateObject(testcase.teacher, out messageResult);
                Assert.AreEqual(testcase.expected, actual);
            }
        }
    }
}
