using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CommonDTO.Models_DTO
{
    [DataContract]
    public class PhoneDTO
    {
        [DataMember]
        [Key]
        public Guid IdContact { get; set; }

        [DataMember]
        [Key]
        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string PhoneType { get; set; }
    }
}
