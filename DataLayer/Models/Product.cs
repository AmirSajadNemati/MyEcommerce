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

        [Display(Name = "دسته بندی")]
        public int CategoryID { get; set; }

        [Display(Name = "نام محصول")]
        [MaxLength(150)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ProductName { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Range(0, 9999999999999999.99)]
        public decimal ProductPrice { get; set; }

        [Display(Name = "توضیح کوتاه")]
        [MaxLength(250)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ShortDescription { get; set; }

        [Display(Name = "جزيیات")]
        [MaxLength(500)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ProductDetail { get; set; }

        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ProductImageName { get; set; }

        [Display(Name = "درباره ی سازنده")]
        [MaxLength(500)]
        public string AboutProducer { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "در اسلایدر نمایش بده")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "موجود / ناموجود")]
        public bool InStock { get; set; }

        [Display(Name = "برچسب ها")]
        public string ProductTags { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تعداد موجود")]
        public int Count { get; set; }

        [Display(Name = "بازدید")]
        
        public int Visit { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public Product()
        {

        }

    }
}
