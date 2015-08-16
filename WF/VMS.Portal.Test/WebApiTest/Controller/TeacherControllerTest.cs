using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VMS.Model.TeacherModel;
using VMS.Model.DAL;
using VMS.PortalApi.Controllers;
using VMS.Test.WebApiTest.Model;
using System.Collections.Generic;
using System.Web.Http.Results;
using System.Linq;

namespace VMS.Portal.Test.WebApiTest.Controller
{
    [TestClass]
    public class TeacherControllerTest
    {
        IVMSContext _context;
        TeacherController _controller;

        [TestInitialize]
        public void InitTest()
        {
            _context = GetFakeContext();
            _controller = new TeacherController(_context);
        }

        private IVMSContext GetFakeContext()
        {
            IVMSContext context = new FakeContext();
            context.Teachers.Add(new TestObject().MyTeacher);
            return context;
        }

        [TestMethod]
        public void GetTeacher()
        {
            var teachers = _controller.GetTeachers();
            var result = (teachers as OkNegotiatedContentResult<List<Teacher>>).Content;
            Assert.AreEqual(_context.Teachers.Local.Count, result.Count());
        }
    }
}
