using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Models
{
    public class Band
    {
        [Display(Name = "Nome do musico")]
        public string Title { get; set; }
        [Display(Name = "Genero musical")]
        [Required(ErrorMessage = "Genre is required")]
        public string Genre { get; set; }
        [Display(Name = "Origem do musico")]
        [RegularExpression(@"\d", ErrorMessage = "stupid rule")]
        public string Origin { get; set; }
        [Display(Name = "Biografia")]
        
        public string Biography { get; set; }
    }
}
