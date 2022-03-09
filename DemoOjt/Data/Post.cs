using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoOjt.Data
{

    public class Post
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
    }
    public class Category
    {
        public string id { get; set; }
        public string Name { get; set; }
    }
}
