using Library.Domain.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Domain
{
    public class Book : IEntity<int>
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string isBN { get; set; }


        public virtual ICollection<Page> Pages { get; set; }

    }
}
