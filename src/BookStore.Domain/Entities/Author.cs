﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MinLength(20)]
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
