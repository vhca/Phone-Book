﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CommonDTO.Models_DTO
{
    [DataContract]
    public class ContactDTO
    {
        #region Properties

        [DataMember]
        [Key]
        public Guid IdContact { get; set; }

        [DataMember]
        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [DataMember]
        public DateTime BirdtDate { get; set; }

        [DataMember]
        public List<PhoneDTO> Phone { get; set; }

       
        #endregion

        #region Constructors
        public ContactDTO()
        {
            IdContact = Guid.NewGuid();
            Phone = new List<PhoneDTO>();
        }

       

        #endregion        
    }
}
