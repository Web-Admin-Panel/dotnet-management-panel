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

        // Change this property type from decimal to double
        [Column("price")]
        public double Price { get; set; }
    }
}