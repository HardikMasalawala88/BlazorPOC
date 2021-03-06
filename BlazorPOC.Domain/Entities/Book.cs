using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPOC.Domain.Entities
{
    public class Book
    {
        public Book() =>
            CreatedDate = DateTime.Now;

        public Book(int id, string title, string author, string category, int quantity, decimal price) : this()
        {
            Id = id;
            Title = title;
            Author = author;
            Category = category;
            Quantity = quantity;
            Price = price;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
