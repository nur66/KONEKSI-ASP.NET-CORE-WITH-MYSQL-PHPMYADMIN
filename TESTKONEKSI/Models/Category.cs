using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TESTKONEKSI.Models
{
    public class Category
    {
        //Key, Required, DisplayName disebut anotasi
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        //[Range(1,100)] bisa menggunakan error default, tetapi kita juga custom
        [Range(1, 100, ErrorMessage = "Nur - Display order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
