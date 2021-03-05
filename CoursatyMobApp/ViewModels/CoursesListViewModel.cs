using CoursatyMobApp.Models;
using CoursatyMobApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CoursatyMobApp.ViewModels
{
    public class CoursesListViewModel : BaseViewModel
    {
        public IEnumerable<Course> Courses { set; get; }

        private readonly CoursesService coursesService;
        public CoursesListViewModel(int? categoryId = null)
        {
            coursesService = new CoursesService();

            if(categoryId == null)
                Courses = coursesService.GetCourses();
            else
                Courses = coursesService.GetCourses(categoryId.Value);


        }
    }
}
