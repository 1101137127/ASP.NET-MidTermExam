using AopAlliance.Intercept;
using KuasCore.Models;
using System;
using System.Diagnostics;

namespace KuasCore.Interceptors 
{
    class UpdateCourseNameInterceptor : IMethodInterceptor
    {

        public object Invoke(IMethodInvocation invocation)
        {

            Console.WriteLine("UpdateCourseNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("UpdateCourseNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();

            if (result is Course)
            {
                Course course = (Course)result;
                course.CourseName = course.CourseName + " 上面偷偷加東西";
                result = course;
            }

            return result;
        }
    }
}
