using CoursatyMobApp.Models;
using CoursatyMobApp.ViewModels;
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
    public partial class CoursesPage : ContentPage
    {
        public CoursesPage()
        {
            InitializeComponent();
            BindingContext = new CoursesListViewModel();
        }
        public CoursesPage(int? categoryId = null)
        {
            InitializeComponent();
            BindingContext = new CoursesListViewModel(categoryId);
        }

        private async void lstCourses_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var course = e.SelectedItem as Course;
            if (course != null)
            {
                await Navigation.PushAsync(new CourseInfoDetailPage(course));
            }

            lstCourses.SelectedItem = null;
        }
    }
}