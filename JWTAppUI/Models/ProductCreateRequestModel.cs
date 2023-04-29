using System.ComponentModel.DataAnnotations;

namespace JWTAppUI.Models
{
    public class ProductCreateRequestModel
    {
        [Required(ErrorMessage ="Ürün Adı Boş Bırakılamaz")]
        public string Name { get; set; }
        public int Stock { get; set; }

        [Required(ErrorMessage ="Ürün Fiyatı Boş Bırakılamaz")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="Ürün Kategorisi Boş Bırakılamaz")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Ürün Tedarikçisi Boş Bırakılamaz")]
        public int SupplierId { get; set; }
    }
}
