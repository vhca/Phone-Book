using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CommonDTO.Models_DTO
{
    [DataContract]
    public class AddressDTO
    {
        [DataMember]
        [Key]
        public Guid IdContact { get; set; }

        [DataMember]
        [Key]
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [DataMember]
        [MaxLength(30)]
        public string City { get; set; }

        [DataMember]
        [MaxLength(20)]
        public string Country { get; set; }
    }
}
