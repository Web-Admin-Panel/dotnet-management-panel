using System.ComponentModel.DataAnnotations.Schema;

namespace WebHelloWorld.Models
{
    public class UserTopic
    {
        [Column("user_id")]
        public int UserId { get; set; }
        public User User { get; set; }
        
        [Column("topic_id")]
        public string TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}