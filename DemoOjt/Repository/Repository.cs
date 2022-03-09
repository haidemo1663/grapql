using DemoOjt.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoOjt.Repository
{
    public class PostRepository : IRepository
    {
        private readonly IList<Post> _post;
        private const string _fullPath = @"D:/OJT/project/DemoOjt/Data/data.json";
        public PostRepository()
        {
            _post = JsonSerializer.Deserialize<List<Post>>(File.ReadAllText(_fullPath));
        }
        public IList<Post> CreatePost(Post post)
        {
            var exist = _post.SingleOrDefault(p => p.Url == post.Url);
            if (exist != null)
            {
                throw new Exception("Exist!!");
            }
            _post.Add(post);
            string json = JsonSerializer.Serialize(_post);
            File.WriteAllText(_fullPath, json);
            return _post;
        }
        public IList<Post> DeletePost(string id)
        {

            var exist = _post.SingleOrDefault(p => p.Id == id);
            if (exist != null)
            {
                _post.Remove(exist);
                string json = JsonSerializer.Serialize(_post);
                File.WriteAllText(_fullPath, json);
                return _post;
            }
            throw new Exception("Not Found");
        }
        public IList<Post> GetAllPost()
        {
            return _post;
        }
        public Post GetPost(string id)
        {
            return _post.SingleOrDefault(p => p.Id == id);

        }
        public IList<Post> UpdatePost(string id, Post post)
        {

            var exist = _post.SingleOrDefault(p => p.Id == id);
            if (exist == null)
            {
               throw new Exception("Not Found!!");
            }
            var index = _post.IndexOf(exist);
            _post[index] = post;
            string json = JsonSerializer.Serialize(_post);
            File.WriteAllText(_fullPath, json);
            return _post;
        }

    }
}
