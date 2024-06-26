﻿namespace BookStore.Models.Models
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int AuthorId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Value { get; set; } = string.Empty;

        public string Sender { get; set; } = string.Empty;
    }
}
