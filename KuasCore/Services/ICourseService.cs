using KuasCore.Dao;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services
{

    /// <summary>
    ///     課程資料維護的 Service.
    /// </summary>
    public interface ICourseService
    {

        /// <summary>
        ///     新增課程資料.
        /// </summary>
        /// <param name="course">
        ///     課程資料.
        /// </param>
        void AddCourse(Course course);

        /// <summary>
        ///     修改課程資料.
        /// </summary>
        /// <param name="course">
        ///     課程資料.
        /// </param>
        void UpdateCourse(Course course);

        /// <summary>
        ///     刪除課程資料.
        /// </summary>
        /// <param name="course">
        ///     課程資料.
        /// </param>
        void DeleteCourse(Course course);

        /// <summary>
        ///     取得所有課程資料.
        /// </summary>
        /// <returns>
        ///     所有課程資料.
        /// </returns>
        IList<Course> GetAllCourses();

        /// <summary>
        ///     依據 ID 取得課程資料.
        /// </summary>
        /// <param name="id">
        ///     課程 Id.
        /// </param>
        /// <returns>
        ///     該課程資料.
        /// </returns>
        Course GetCourseById(string id);

    }
}
