using KuasCore.Models;
using Spring.Data.Generic;
using System.Data;

namespace KuasCore.Dao.Mapper
{
    class CourseRowMapper : IRowMapper<Course>
    {
        public Course MapRow(IDataReader dataReader, int rowNum)
        {
            Course target = new Course();

            target.CourseId = dataReader.GetString(dataReader.GetOrdinal("Id"));
            target.CourseName = dataReader.GetString(dataReader.GetOrdinal("Name"));
            target.CourseDescription = dataReader.GetString(dataReader.GetOrdinal("Description"));

            return target;
        }

    }
}
