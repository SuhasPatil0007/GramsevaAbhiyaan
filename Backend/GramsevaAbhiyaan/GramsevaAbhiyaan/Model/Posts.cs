﻿namespace GramsevaAbhiyaan.Model
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}
