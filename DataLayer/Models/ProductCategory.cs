using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductCategory
    {
        [Key]
        public int CategoryID { get; set; }

        [Display(Name = "")]
        [MaxLength()]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }

        public ProductCategory()
        {

        }
    }
}
