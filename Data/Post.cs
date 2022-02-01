﻿using System.ComponentModel.DataAnnotations;

namespace BlazorAppDemo.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Title { get; set; }

        [MaxLength(4096)]
        public string Content { get; set; }
    }
}
