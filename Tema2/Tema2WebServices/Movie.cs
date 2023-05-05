namespace Tema2WebServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

        public int Duration { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        public int Rating { get; set; }

        public bool Watched { get; set; }
    }
}
