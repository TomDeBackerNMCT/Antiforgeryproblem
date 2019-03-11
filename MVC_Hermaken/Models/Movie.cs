using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Hermaken.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Please, enter a valid title in text form.")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, enter a valid date.")]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(30)]
        [Required(ErrorMessage = "Please, enter a valid genre in text form.")]
        [DataType(DataType.Text)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [Required(ErrorMessage = "Please, enter a valid price. (Must be a number)")]
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(1)]
        [Required]
        public string Rating { get; set; }
    }
}
