using BlogAPI.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.ComponentModel.DataAnnotations;

namespace BlogAPI.Model
{
    public class Post
    {
        [Key]
        public Guid id { get ; private set; }
        public string? title { get; private set; }
        public string? content { get; private set; }
        public DateTime createdAt  { get; private set; }
        public DateTime updatedAt { get; private set; }

        public Post(string title, string content, DateTime createdAt, DateTime updatedAt)
        {
            this.title = title;
            this.content = content;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }

        public Post(RequestPostDto post)
        {
            title = post.title;
            content = post.content;
            createdAt = updatedAt = DateTime.UtcNow;
        }

        public void Update(RequestPostDto post)
        {
            if(title != post.title)
                title = post.title;
            if(content != post.content)
                content = post.content;

            this.updatedAt = DateTime.UtcNow;
        }
    }
}
