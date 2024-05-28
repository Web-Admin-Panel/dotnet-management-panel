using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace WebHelloWorld.Models;

public class Topic
{
    [Column("topic_id")]
    [Required]
    public string TopicId { get; set; }

    [Column("name")]
    [Required]
    public string Name { get; set; }
    
    [Column("description")]
    public string? Description { get; set; }
    
    public ICollection<UserTopic> UserTopics { get; set; } = new List<UserTopic>();
    
    public ICollection<TopicCourse> TopicCourses { get; set; } = new List<TopicCourse>();
    
}

