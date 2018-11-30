using Library.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library.Domain
{
    public class Page : IEntity<long>
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string Format { get; set; }

        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }

    }
}
