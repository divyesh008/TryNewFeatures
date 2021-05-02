using System;
namespace NewControlsDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSelected { get; set; }
    }
}
