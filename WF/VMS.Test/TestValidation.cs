using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VMS.Model.TeacherModel;
using VMS.WebApi.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using VMS.Base;

namespace VMS.Test
{
    [TestClass]
    public class TestValidation
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
                var actual = APIhelper.ValidateObject(testcase.teacher, out messageResult);
                Assert.AreEqual(testcase.expected, actual);
            }
        }

        [TestMethod]
        public void Validate_Email()
        {
            #region prepare
            var testcases = new[]
            {
                new{emailString= "duy.tran.k1set@eiu.edu.vn", expected = true},
                new{emailString= "",  expected = false},      
                new{emailString= "duy.tran@eiu.edu.vn",expected = true},     
                new{emailString= "duy.tran@gmail.com",expected = false}, 
                new{emailString= "duy.tran@yahoo.com",expected = false}, 
                new{emailString= "@yahoo.com",expected = false}, 
            };
            #endregion
            foreach (var testcase in testcases)
            {
                var actual = RegexUtility.IsValidEiuEmail(testcase.emailString);
                Assert.AreEqual(testcase.expected, actual);
            }
        }
    }
}
