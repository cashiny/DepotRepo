
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public Address MainAddress { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        public string State { get; set; }
        public string Zip { get; set; }
    }
}
