using System;
using System.Collections.Generic;
using System.Text;

namespace CoursatyMobApp.Models
{
    public enum MenuItemType
    {
        Courses,
        Categories,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
