using BlogAPI.Dto;
using BlogAPI.Model;
using BlogAPI.Repositories;
using Microsoft.Extensions.Hosting;

namespace BlogAPI.Services
{
    public class PostService
    {
        private readonly PostRepository repository;

        public PostService(PostRepository repository)
        {
            this.repository = repository;
        }

        public void Add(RequestPostDto post)
        {
            repository.Add(new Post(post));
        }

        public List<ResponsePostDto> GetAll()
        {
            var posts = repository.GetAll();
            return posts.Select(post => new ResponsePostDto(post)).ToList();
        }

        public ResponsePostDto GetById(Guid id)
        {
            var post = repository.GetById(id);
            if (post is null)
                throw new Exception("Post não encontrado!");

            return new ResponsePostDto(post);
        }

        public void Update(Guid id, RequestPostDto post)
        {
            var postDb = repository.GetById(id);
            if (postDb is null)
                throw new Exception("Post não encontrado!");

            postDb.Update(post);
            repository.Update(postDb);
        }

        public void Delete(Guid id)
        {
            var postDb = repository.GetById(id);
            if (postDb is null)
                throw new Exception("Post não encontrado!");
            repository.Delete(postDb);
        }
    }
}
