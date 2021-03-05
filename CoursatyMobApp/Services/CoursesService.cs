using System;
using System.Collections.Generic;
using System.Text;
using CoursatyMobApp.Models;

namespace CoursatyMobApp.Services
{
    public class CoursesService
    {
        public IEnumerable<Course> GetCourses()
        {
            var requestService = new BaseService<Course>();
            return requestService.GetRequest("/courses");
        }

        public IEnumerable<Course> GetCourses(int categoryId)
        {
            var requestService = new BaseService<Course>();
            return requestService.GetRequest($"/categories/{categoryId}/courses");
        }
    }
}
