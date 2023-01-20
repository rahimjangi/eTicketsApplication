using System;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public abstract class Base
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
    }
}
