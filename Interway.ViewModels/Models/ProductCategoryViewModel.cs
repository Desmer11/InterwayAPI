using InterwayAPI.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace InterwayAPI.ViewModels.Models
{
    public class ProductCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductCategoryStatusEnum ProductCategoryStatus { get; set; }
    }
}
