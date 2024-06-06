using Microsoft.EntityFrameworkCore;
using WebHelloWorld.Models;

namespace WebHelloWorld.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
        
        public DbSet<Admin> Admins { get; set; } // Add this line
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UserTopic> UserTopics { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<TopicCourse> TopicCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().ToTable("courses");
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Admin>().ToTable("admins");
            modelBuilder.Entity<Topic>().ToTable("topics");
            modelBuilder.Entity<UserTopic>().ToTable("user_topics");
            modelBuilder.Entity<UserCourse>().ToTable("user_courses");
            modelBuilder.Entity<TopicCourse>().ToTable("topic_course");

            // Additional configurations (like setting up relationships) can also be added here
            modelBuilder.Entity<TopicCourse>()
                .HasKey(tc => new { tc.CourseId, tc.TopicId });

            // Define the relationship between TopicCourse and Course
            modelBuilder.Entity<TopicCourse>()
                .HasOne(tc => tc.Course)
                .WithMany(c => c.TopicCourses) // Ensure Course has a collection of TopicCourse
                .HasForeignKey(tc => tc.CourseId);

            // Define the relationship between TopicCourse and Topic
            modelBuilder.Entity<TopicCourse>()
                .HasOne(tc => tc.Topic)
                .WithMany(t => t.TopicCourses) // Ensure Topic has a collection of TopicCourse
                .HasForeignKey(tc => tc.TopicId);
            
            
            modelBuilder.Entity<UserCourse>()
                .HasKey(tc => new { tc.CourseId, tc.UserId });

            modelBuilder.Entity<UserCourse>()
                .HasOne(tc => tc.Course)
                .WithMany(c => c.UserCourses)
                .HasForeignKey(tc => tc.CourseId);

            modelBuilder.Entity<UserCourse>()
                .HasOne(tc => tc.User)
                .WithMany(t => t.UserCourses)
                .HasForeignKey(tc => tc.UserId);
            
            
            modelBuilder.Entity<UserTopic>()
                .HasKey(tc => new { tc.TopicId, tc.UserId });

            modelBuilder.Entity<UserTopic>()
                .HasOne(tc => tc.Topic)
                .WithMany(c => c.UserTopics)
                .HasForeignKey(tc => tc.TopicId);

            modelBuilder.Entity<UserTopic>()
                .HasOne(tc => tc.User)
                .WithMany(t => t.UserTopics)
                .HasForeignKey(tc => tc.UserId);
        }
    }
}

