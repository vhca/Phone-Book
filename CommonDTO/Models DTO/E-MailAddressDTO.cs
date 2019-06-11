using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CommonDTO.Models_DTO
{
    [DataContract]
    public class E_MailAddressDTO
    {
        [DataMember]
        [Key]
        public Guid IdContact { get; set; }

        [DataMember]
        [Key]
        [Required]
        [MaxLength(50)]
        public string EMailAddress { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string EmailType { get; set; }
    }
}
