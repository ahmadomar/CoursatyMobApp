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
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
            BindingContext = new CategoriesListViewModel();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var category = e.SelectedItem as Category;
            if(category != null)
            {
                await Navigation.PushAsync(new CoursesPage(category.Id));
            }

            lstCategories.SelectedItem = null;
        }
    }
}