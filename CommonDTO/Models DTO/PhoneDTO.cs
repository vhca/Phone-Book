using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CommonDTO.Models_DTO
{
    [DataContract]
    public class PhoneDTO
    {
        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string PhoneType { get; set; }
    }
}
