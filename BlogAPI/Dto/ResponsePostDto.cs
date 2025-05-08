using BlogAPI.Model;
using System;

namespace BlogAPI.Dto
{
    public class ResponsePostDto
    {
        public Guid id { get; set; }
        public string? title { get;  set; }
        public string? content { get;  set; }
        public DateTime createdAt { get;  set; }

        public ResponsePostDto(Post post)
        {
            this.id = post.id;
            this.title = post.title;
            this.content = post.content;
            this.createdAt = post.createdAt;
        }
    }
}
