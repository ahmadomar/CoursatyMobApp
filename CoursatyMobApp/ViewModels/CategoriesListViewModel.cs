using CoursatyMobApp.Models;
using CoursatyMobApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CoursatyMobApp.ViewModels
{
    public class CategoriesListViewModel : BaseViewModel
    {
        public IEnumerable<Category> Categories { set; get; }

        private readonly CategoryService categoryService;
        public CategoriesListViewModel()
        {
            categoryService = new CategoryService();
            Categories = categoryService.GetCategories();
        }
    }
}
