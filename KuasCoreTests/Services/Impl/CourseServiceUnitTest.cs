using KuasCore.Dao;
using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;

namespace KuasCoreTests.Services
{
    [TestClass]
    public class CourseServiceUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    //assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCorePointcut.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public ICourseService CourseService { get; set; }

        [TestMethod]
        public void TestEmployeeService_AddCourse()
        {
            Course course = new Course();
            course.CourseId = "UnitTests";
            course.CourseName = "單元測試";
            course.CourseDescription = "讚讚讚";
            CourseService.AddCourse(course);

            Course dbCourse = CourseService.GetCourseById(course.CourseId);
            Assert.IsNotNull(dbCourse);
            Assert.AreEqual(course.CourseId, dbCourse.CourseId);

            Console.WriteLine("員工編號為 = " + dbCourse.CourseId);
            Console.WriteLine("員工姓名為 = " + dbCourse.CourseName);
            Console.WriteLine("員工年齡為 = " + dbCourse.CourseDescription);

            CourseService.DeleteCourse(dbCourse);
            dbCourse = CourseService.GetCourseById(course.CourseId);
            Assert.IsNull(dbCourse);
        }

        [TestMethod]
        public void TestCourseService_UpdateCourse()
        {
            // 取得資料
            Course course = CourseService.GetCourseById("dennis_yen");
            Assert.IsNotNull(course);

            // 更新資料
            course.CourseName = "單元測試";
            CourseService.UpdateCourse(course);

            // 再次取得資料
            Course dbCourse = CourseService.GetCourseById(course.CourseId);
            Assert.IsNotNull(dbCourse);
            Assert.AreEqual(course.CourseName, dbCourse.CourseName);

            Console.WriteLine("課程編號為 = " + dbCourse.CourseId);
            Console.WriteLine("課程姓名為 = " + dbCourse.CourseName);
            Console.WriteLine("課程年齡為 = " + dbCourse.CourseDescription);

            Console.WriteLine("================================");

            // 將資料改回來
            course.CourseName = "嚴志和";
            CourseService.UpdateCourse(course);

            // 再次取得資料
            dbCourse = CourseService.GetCourseById(course.CourseId);
            Assert.IsNotNull(dbCourse);
            Assert.AreEqual(course.CourseName, dbCourse.CourseName);

            Console.WriteLine("課程編號為 = " + dbCourse.CourseId);
            Console.WriteLine("課程姓名為 = " + dbCourse.CourseName);
            Console.WriteLine("課程年齡為 = " + dbCourse.CourseDescription);
        }


        [TestMethod]
        public void TestCourseService_DeleteCourse()
        {
            Course newCourse = new Course();
            newCourse.CourseId = "UnitTests";
            newCourse.CourseName = "單元測試";
            newCourse.CourseDescription = "讚讚讚";
            CourseService.AddCourse(newCourse);

            Course dbCourse = CourseService.GetCourseById(newCourse.CourseId);
            Assert.IsNotNull(dbCourse);

            CourseService.DeleteCourse(dbCourse);
            dbCourse = CourseService.GetCourseById(newCourse.CourseId);
            Assert.IsNull(dbCourse);
        }

        [TestMethod]
        public void TestCourseService_GetCourseById()
        {
            Course course = CourseService.GetCourseById("dennis_yen");
            Assert.IsNotNull(course);

            Console.WriteLine("課程編號為 = " + course.CourseId);
            Console.WriteLine("課程姓名為 = " + course.CourseName);
            Console.WriteLine("課程年齡為 = " + course.CourseDescription);
        }

    }
}
