using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "")]
        public int CategoryID { get; set; }

        [Display(Name = "")]
        [MaxLength()]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ProductName { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Range(0, 9999999999999999.99)]
        public decimal ProductPrice { get; set; }

        [Display(Name = "")]
        [MaxLength()]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ShortDescription { get; set; }

        [Display(Name = "")]
        [MaxLength()]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ProductDetail { get; set; }

        [Display(Name = "")]
        [MaxLength()]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ProductImageName { get; set; }

        [Display(Name = "")]
        [MaxLength()]
        public string AboutProducer { get; set; }

        [Display(Name = "")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "")]
        public bool InStock { get; set; }

        [Display(Name = "")]
        [MaxLength()]
        public string ProductTags { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "")]
        public int Count { get; set; }

        [Display(Name = "")]
        public int Visit { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public Product()
        {

        }

    }
}
