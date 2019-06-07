using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CommonDTO
{
    [DataContract]
    public class PersonDTO
    {
        #region Properties

        [DataMember]
        [Key]
        public Guid Id { get; set; }

        [DataMember]
        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string ImageSource { get; set; }

        #endregion

        #region Constructors
        public PersonDTO()
        {
            Id = Guid.NewGuid();
        }
        #endregion        
    }
}
