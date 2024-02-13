using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreContact.DataLayer.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "نام ونام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} وارد نمایید")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "تلفن ثابت")]
        [Required(ErrorMessage = "لطفا {0} وارد نمایید")]
        [MaxLength(50)]
        public string Tel { get; set; }

        [Display(Name = "موبایل")]
        [Required(ErrorMessage = "لطفا {0} وارد نمایید")]
        [MaxLength(50)]
        public string Mobile { get; set; }

        [Display(Name = "کدپستی")]
        [Required(ErrorMessage = "لطفا {0} وارد نمایید")]
        [MaxLength(10)]
        public string Zipcode { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} وارد نمایید")]
        [MaxLength(500)]
        public string Address { get; set; }

       
        public string AdditionalInfo { get; set; } // Example of another property


    }
}
