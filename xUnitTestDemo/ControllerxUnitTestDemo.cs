using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DemoOjt.Controllers;
using DemoOjt.Data;
using DemoOjt.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace xUnitTestDemo
{
    public class ControllerxUnitTestDemo
    {
        private readonly Mock<IRepository> _repository;
        public ControllerxUnitTestDemo()
        {
            _repository = new Mock<IRepository>();
        }
        private List<Post> GetTestPost()
        {
            var posts = new List<Post>()
            {
                new Post(){Id = "0f8fad5b-d9cb-469f-a165-70867728950e", Name = "lanqhe321", Url ="https://htran844.github.io/hihi/img/ig/i1.jpg"},
                new Post(){Id = "7c9e6679-7425-40de-944b-e07fc1f90ae7", Name = "huongqnlt123", Url ="https://htran844.github.io/hihi/img/ig/i2.jpg"}
            };
            return posts;
        }
        [Fact]
        public void Index_ReturnsResult_WithAListOfPost()
        {
            //Arrange
            _repository.Setup(repo => repo.GetAllPost()).Returns(GetTestPost);
            var controller = new PostController(_repository.Object);
            // Act
            var result = controller.Index();
            var okObjectResult = Assert.IsType<OkObjectResult>(result);
        }
    }
}
