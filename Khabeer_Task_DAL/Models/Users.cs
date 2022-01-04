using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khabeer_Task_DAL.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "ArabicName is required")]
        public string ArabicName { get; set; }
        [Required(ErrorMessage = "EnglishName is required")]
        public string EnglishName { get; set; }
        [Required(ErrorMessage = "MapLat is required")]
        public double MapLat { get; set; }
        [Required(ErrorMessage = "Maplng is required")]
        public double  Maplng { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
    }
}
