
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class CourseDao : GenericDao<Course>
    {

        override protected IRowMapper<Course> GetRowMapper()
        {
            return new CourseRowMapper();
        }

        public void AddCourse(Course course)
        {
            string command = @"INSERT INTO Course (CourseId, CourseName, CourseDescription) VALUES (@Id, @Name, @Description);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.CourseId;
            parameters.Add("Name", DbType.String).Value = course.CourseName;
            parameters.Add("Description", DbType.String).Value = course.CourseDescription;

            ExecuteNonQuery(command, parameters);
        }

        public void UpdateCourse(Course course)
        {
            string command = @"UPDATE Course SET CourseName = @Name, Description = @Description WHERE CourseId = @Id;";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.CourseId;
            parameters.Add("Name", DbType.String).Value = course.CourseName;
            parameters.Add("Description", DbType.String).Value = course.CourseDescription;

            ExecuteNonQuery(command, parameters);
        }

        public void DeleteCourse(Course course)
        {
            string command = @"DELETE FROM Course WHERE CourseId = @Id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.CourseId;

            ExecuteNonQuery(command, parameters);
        }

        public IList<Course> GetAllCourses()
        {
            string command = @"SELECT * FROM Course ORDER BY CourseId ASC";
            IList<Course> Courses = ExecuteQueryWithRowMapper(command);
            return Courses;
        }

        public Course GetCourseById(string id)
        {
            string command = @"SELECT * FROM Course WHERE CourseId = @Id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = id;

            IList<Course> Courses = ExecuteQueryWithRowMapper(command, parameters);
            if (Courses.Count > 0)
            {
                return Courses[0];
            }

            return null;
        }

    }
}
