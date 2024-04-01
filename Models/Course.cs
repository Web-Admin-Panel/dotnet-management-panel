using System.ComponentModel.DataAnnotations.Schema;

namespace WebHelloWorld.Models
{
    public class Course
    {
        [Column("course_id")]
        public int CourseId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }
        
        [Column("price")]
        public double Price { get; set; }

        public ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
        public ICollection<TopicCourse> TopicCourses { get; set; } = new List<TopicCourse>();


    }
}