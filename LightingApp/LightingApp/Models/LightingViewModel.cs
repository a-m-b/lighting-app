using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LightingApp.Models
{
    public class LightingViewModel
    {
        public int ID { get; set; }

        [MaxLength(50)]
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Email Address")]
        [Required]
        public string EmailAddress { get; set; }

        [DisplayName("Acceptable Lighting")]
        [Required]
        public bool AcceptableLighting { get; set; }

        [DisplayName("Level of Brightness")]
        [Required]
        public int BrightnessLevel { get; set; }

        [DisplayName("Name/Number")]
        [Required]
        public string AddressNameOrNumber { get; set; }

        [DisplayName("Street")]
        [Required]
        public string AddressLine1 { get; set; }

        [DisplayName("Area")]
        public string AddressLine2 { get; set; }

        [DisplayName("Town/City")]
        [Required]
        public string AddressTown { get; set; }

        [DisplayName("Postcode")]
        [Required]
        public string AddressPostcode { get; set; }
    }
}
