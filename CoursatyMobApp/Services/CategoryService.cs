using System;
using System.Collections.Generic;
using System.Text;
using CoursatyMobApp.Models;

namespace CoursatyMobApp.Services
{
    public class CategoryService
    {
        public IEnumerable<Category> GetCategories()
        {
            var requestService = new BaseService<Category>();
            return requestService.GetRequest("/categories");
        }
    }
}
