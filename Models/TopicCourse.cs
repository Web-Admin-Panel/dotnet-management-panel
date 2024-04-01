using System.ComponentModel.DataAnnotations.Schema;

namespace WebHelloWorld.Models
{
    public class TopicCourse
    {
        [Column("course_id")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        
        [Column("topic_id")]
        public string TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}