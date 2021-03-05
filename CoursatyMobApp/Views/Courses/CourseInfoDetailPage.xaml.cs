using CoursatyMobApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoursatyMobApp.Views.Courses
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseInfoDetailPage : ContentPage
    {
        public CourseInfoDetailPage(Course course)
        {
            InitializeComponent();
            BindingContext = course;
            Title = course.Name;
        }
    }
}