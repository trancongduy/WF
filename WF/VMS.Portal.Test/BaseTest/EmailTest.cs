using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VMS.Model.TeacherModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using VMS.Base;

namespace VMS.Portal.Test.BaseTest
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void Validate_EiuEmail()
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
                var actual = ValidateEmail.IsValidEiuEmail(testcase.emailString);
                Assert.AreEqual(testcase.expected, actual);
            }
        }
    }
}
