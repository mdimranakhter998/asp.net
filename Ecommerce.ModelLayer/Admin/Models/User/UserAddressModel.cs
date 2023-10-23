using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ModelAccessLayer.Admin.Models.User
{
    public class UserAddressModel
    {
        [Display(Name = "Id")]
        public int UserAddressId { get; set; }
        [Display(Name = "User Id")]
        public int UserId { get; set; }
        [Display(Name = "Address Type Id")]
        public int AddressTypeId { get; set; }
        [Display(Name = "Full Address")]
        public string FullAddress { get; set; }
        [Display(Name = "Pin Code")]
        public string PostalCode { get; set; }
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }
        [Display(Name = "Status Id")]
        public int StatusId { get; set; }
        [Display(Name = "City Id")]
        public int CityId { get; set; }



    }
}
