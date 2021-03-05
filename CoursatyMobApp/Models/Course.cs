namespace CoursatyMobApp.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Creation { get; set; }
        public int? Category { get; set; }
        public string Image { get; set; }
    }
}
