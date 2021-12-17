using System.ComponentModel.DataAnnotations;

namespace OfflineBlazor.Data
{
    public class Address
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string State { get; set; }


        public override string ToString()
        {
            return $"{Street} {PostCode} {City} {State}";
        }
    }
}
