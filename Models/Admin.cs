using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;

namespace WebHelloWorld.Models;

public class Admin
{
    [Key]
    [Column("user_id")]
    public Int64 AdminUserId { get; set; }

    [Column("admin_level")]
    public int AdminLevel { get; set; }

    [Column("password")]
    public string? AdminPassword { get; set; }
    
    // public User User { get; set; }
}

