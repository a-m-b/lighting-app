using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LightingApp.Data.Models
{
    public class Lighting
    {
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public bool AcceptableLighting { get; set; }

        public int BrightnessLevel { get; set; }

        public string AddressNameOrNumber { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressTown { get; set; }

        public string AddressPostcode { get; set; }
    }
}
