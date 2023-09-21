using System.ComponentModel.DataAnnotations;

namespace EcommerceUI.Admin.Models.User
{
    public class AddressTypeModel
    {
        public int AddressTypeId { get; set; }

        [Display(Name ="Address Type")]
        public string AddressType { get; set; }
    }
}
