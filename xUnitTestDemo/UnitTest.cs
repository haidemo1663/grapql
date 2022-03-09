// using DemoOjt.Repository;
// using System;
// using Xunit;
// using FluentAssertions;
// using DemoOjt.Data;
// using Moq;
// namespace xUnitTestDemo
// {
//     public class UnitTest
//     {
//         private readonly IRepository _repository;
//         public UnitTest()
//         {
//             _repository = new PostRepository();
//         }
//         [Fact]
//         public  void GetAllPost_Return_ShouldReturnList()
//         {
//             var posts = _repository.GetAllPost();
//             Assert.Equal(2, posts.Count);
//         }
//         [Fact]
//         public void GetPost_Returns_ShouldExitst()
//         {
//             string id = "0f8fad5b-d9cb-469f-a165-70867728950e";
//             var post = _repository.GetPost(id);
//             Assert.Equal("lanqhe321", post.Name);
//         }
//         [Fact]
//         public void GetPost_Returns_ShouldNotExist()
//         {
//             string id = Guid.NewGuid().ToString();
//             var post = _repository.GetPost(id);
//             Assert.Equal(default, post);
//         }
//         [Fact]
//         public void CreatePost_Returns_ShouleBeTrue()
//         {
//             var post = new Post() { Id = Guid.NewGuid().ToString(), Url = "https://htran844.github.io/hihi/img/ig/i3.jpg" };
//             var actual = _repository.CreatePost(post);
//             Assert.True(actual);
//         }
//         [Fact]
//         public void CreatePost_Returns_ShouldBeFalse()
//         {
//             var post = new Post() { Id = Guid.NewGuid().ToString(), Url = "https://htran844.github.io/hihi/img/ig/i1.jpg" };
//             var actual = _repository.CreatePost(post);
//             Assert.False(actual);
//         }
//         [Fact]
//         public void QuantityAfterCreate_Returns_ShouldBeAscending()
//         {
//             var post = new Post() { Id = Guid.NewGuid().ToString(), Url = "https://htran844.github.io/hihi/img/ig/i4.jpg" };
//             _repository.CreatePost(post);
//             var actual = _repository.GetAllPost().Count;
//             Assert.Equal(3, actual);
//         }

//         [Theory]
//         [InlineData("0f8fad5b-d9cb-469f-a165-70867728950e")]
//         [InlineData("7c9e6679-7425-40de-944b-e07fc1f90ae7")]
//         public void UpdatePost_Return_ShouldBeTrue(string id)
//         {
//             var post = new Post() { Id = Guid.NewGuid().ToString(), Url = "https://htran844.github.io/hihi/img/ig/i4.jpg" };
//             var actual = _repository.UpdatePost(id, post);
//             Assert.True(actual);
//         }
//         [Fact]
//         public void UpdatePost_Returns_ShouldBeFalse()
//         {
//             var actual = _repository.UpdatePost(Guid.NewGuid().ToString(), new Post());
//             Assert.False(actual);
//         }
//         [Theory]
//         [InlineData("0f8fad5b-d9cb-469f-a165-70867728950e")]
//         [InlineData("7c9e6679-7425-40de-944b-e07fc1f90ae7")]
//         public void DeletePost_Returns_ShouldBeTrue(string id)
//         {
//             var actual = _repository.DeletePost(id);
//             Assert.True(actual);
//         }
//         [Theory]
//         [InlineData("0f8fad5b-d9cb-469f-a165-708677289507")]
//         public void DeletePost_Returns_ShouldBeFalse(string id)
//         {
//             var actual = _repository.DeletePost(id);
//             Assert.False(actual);
//         }

//     }
// }
