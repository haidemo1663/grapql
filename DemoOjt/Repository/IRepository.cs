using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoOjt.Data;
namespace DemoOjt.Repository
{
    public interface IRepository
    {
        IList<Post> GetAllPost();
        IList<Post> CreatePost(Post post);
        IList<Post> UpdatePost(string id, Post post);
        Post GetPost(string id);
        IList<Post> DeletePost(string id);
    }
}
