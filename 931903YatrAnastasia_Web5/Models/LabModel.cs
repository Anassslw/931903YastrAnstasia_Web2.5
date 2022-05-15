using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _YatrAnastasia_Web5.Models
{
    public class LabModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите адрес")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Введите номер телефона")]
        [Display(Name = "Phones")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$", ErrorMessage = "Недопустимый формат")]
        public string Phones { get; set; }
    }
}
