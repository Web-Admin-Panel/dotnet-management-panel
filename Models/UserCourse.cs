using System.ComponentModel.DataAnnotations.Schema;

namespace WebHelloWorld.Models
{
    public class UserCourse
    {
        [Column("user_id")]
        public Int64 UserId { get; set; }
        public User User { get; set; }
        
        [Column("course_id")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        
    }
}