using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace EquipmentLister.Models
{
    public class EquipmentListing
    {
        public Guid ID  = Guid.NewGuid();

        [Required(ErrorMessage = "Please Enter a Name")]
        public string? Name {get; set;}
        
        [Required(ErrorMessage = "Please Enter a Email")]
        [EmailAddress]
        public string? Email {get; set;}
        
        [Required(ErrorMessage = "Please Enter a Phone Number")]
        [Phone]
        public string? Phone {get; set;}


        [Required(ErrorMessage = "Please Provide a Role")]
        public UserRole Role {get; set;}

        [Required(ErrorMessage = "Please Provide Equipment type")]
        public EquipmentType Type {get; set;}

        [Required(ErrorMessage = "Please Provide the Borrow duration")]
        public int BorrowDuration {get; set;}

        [Required(ErrorMessage = "Please provide Avalability")]
        public bool? isAvaliable {get; set;}

        [Required(ErrorMessage = "Please Provide Extra Details")]
        public string? Details {get; set;}
    }
}