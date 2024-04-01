using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;

namespace WebHelloWorld.Models;

public class User
{
    [Column("user_id")]
    public Int32 UserId { get; set; }

    [Column("username")]
    public string? Username { get; set; }

    [Column("first_name")]
    public string? FirstName { get; set; }
    
    [Column("last_name")]
    public string? LastName { get; set; }
    
    [Column("is_admin")]
    public bool IsAdmin { get; set; }
    
    public ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();

    public ICollection<UserTopic> UserTopics { get; set; } = new List<UserTopic>();

}

