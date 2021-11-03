using System.ComponentModel.DataAnnotations;
using System;

namespace WebMvc1.Models
{
    public class FormModel
    {
        [Display(Name = "Imie")]
        public string Name { get; set; }
        [Display(Name = "Data urodzenia")]
        public DateTime Dateofbirth { get; set; }
    }      
}   

