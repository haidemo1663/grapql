using DemoOjt.Data;
using DemoOjt.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net.Http.Headers;

namespace DemoOjt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        /// <summary>
        /// Inverse by call Interface 
        /// </summary>
        private readonly IRepository _repository;
        public PostController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public  IActionResult Index()
        {
            var post = _repository.GetAllPost();
            return Ok(post);
        }
        [HttpPost]
        public IActionResult CreatePost(PostDTO postDTO)
        {
            try
            {

                    var result = _repository.CreatePost(new Post()
                    {
                        Name = postDTO.Name,
                        Url = postDTO.Url,
                        Category = postDTO.Category
                    }) ;
                    return Ok(result);
              
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
        [HttpPut]
        public IActionResult UpdatePost(string id, [FromForm]PostDTO postDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var post =  _repository.GetPost(id);
                    if (post == default)
                    {
                        throw new Exception("Not Found");
                    }
                        var result =  _repository.UpdatePost(id,new Post()
                        {
                            Id = id,
                            Name = postDTO.Name,
                            Url = postDTO.Url,
                            Category = postDTO.Category
                        });
                        return Ok(result);
                    }
            }
            catch (Exception)
            {

                throw;
            }
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetPost(string id)
        {
            try
            {
                var post =  _repository.GetPost(id);
                if (post == default)
                    throw new NullReferenceException("Not Found");
                return Ok(post);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var post =  _repository.GetPost(id);
            if (post == default)
            {
                throw new Exception("Not Found");
            }
            var result =  _repository.DeletePost(id);
            return Ok(result);
        }
    }
}
