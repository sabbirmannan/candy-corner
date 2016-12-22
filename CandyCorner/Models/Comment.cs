using System;
using System.ComponentModel.DataAnnotations;

namespace CandyCorner.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string Message { get; set; }
        public string Username { get; set; }
        public DateTime DatePosted { get; set; }
        public virtual Post ParentPost { get; set; }
    }
}