using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Project_Take_two.Models
{
    public class Travel
    {
       


        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwe!")]
        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długia nazwa")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Proszę podać date rozpoczęcia!")]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "Proszę podać miejsce rozpoczęcia!")]
        public string StartPlace { get; set; }

        public string EndPlace { get; set; }

        [Required]
        public string Participants { get; set; }

        [Required]
        [Display(Name = "Guide")]
        public Guides Guide { get; set; }

        [HiddenInput]
        public DateTime Created { get; set; }





    }
}
