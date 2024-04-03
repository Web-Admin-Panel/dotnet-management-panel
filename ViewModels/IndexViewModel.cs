using System.Collections.Generic;
using WebHelloWorld.Models;

namespace WebHelloWorld.ViewModels
{
    public class IndexViewModel
    {
        public List<Course> Courses { get; set; }
        public List<Topic> Topics { get; set; }
        public List<User> Users { get; set; }
    }
}