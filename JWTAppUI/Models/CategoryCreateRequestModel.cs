using System.ComponentModel.DataAnnotations;

namespace JWTAppUI.Models
{
    public class CategoryCreateRequestModel
    {
        [Required(ErrorMessage = "Kategori Adı Boş Bırakılamaz")]
        public string Definition { get; set; }
    }
}
