﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommonDTO.Models_DTO
{
    public class PhoneBookDTO
    {
        public ContactDTO Contact { get; set; }

        public List<PhoneDTO> Phone { get; set; }
    }
}
