using BlogAPI.Dto;
using BlogAPI.Model;
using BlogAPI.Repositories;
using BlogAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [ApiController]
    [Route("api/post")]
    public class PostController : ControllerBase
    {
        private readonly PostService service;

        public PostController(PostService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var posts = service.GetAll();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] Guid id) {
            var post = service.GetById(id);
            return Ok(post);
        }

        [HttpPost]
        public IActionResult Add([FromBody] RequestPostDto post)
        {
            service.Add(post);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] Guid id, [FromBody] RequestPostDto post) { 
            service.Update(id, post);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            service.Delete(id);
            return NoContent();
        }
    }
}
