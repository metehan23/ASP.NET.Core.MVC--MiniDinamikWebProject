using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProje.Models
{
    public class Anket
    {
        [Required(ErrorMessage ="İsminizi Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Soyadınızı Giriniz")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Mailinizi Giriniz")]
        [EmailAddress(ErrorMessage ="Mail Formatını Düzeltin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon Numarınızı Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Anket Durum Bilginiz Nedir?")]
        public bool? Confirm { get; set; }
    }
}
