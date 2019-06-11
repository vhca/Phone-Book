using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonDTO.Models_DTO;

namespace Memory_Data_Storage
{
    public sealed class MemoryDataRecord
    {
        private static MemoryDataRecord _instance = null;
        private static readonly object _padlock = new object();

        private MemoryDataRecord()
        {
            var jose = new ContactDTO
            {
                Name = "Jose",
                LastName = "Cespedes",
            };

            var david = new ContactDTO
            {
                Name = "David",
                LastName = "Santa cruz",
            };
            var victor = new ContactDTO
            {
                Name = "Victor",
                LastName = "Cossio",
            };

            PhoneBook = new List<PhoneBookDTO>
                {

                    new PhoneBookDTO
                    {
                        Contact = jose,
                        AddressList = new List<AddressDTO>
                        {
                            new AddressDTO
                            {
                                IdContact = jose.IdContact,
                                Address = "Av Santacruz 344",
                                City = "Cochabamba",
                                Country = "Bolivia"
                            }
                        },
                        EmailList = new List<E_MailAddressDTO>
                        {
                            new E_MailAddressDTO
                            {
                                IdContact = jose.IdContact,
                                EMailAddress = "Jhosep50@gmail.com",
                                EmailType = "Personal"
                            }

                        },
                        PhoneList = new List<PhoneDTO>
                        {
                            new PhoneDTO
                            {
                                IdContact = jose.IdContact,
                                PhoneNumber = "73793714",
                                PhoneType = "Movile"
                            },
                            new PhoneDTO
                            {
                                IdContact = jose.IdContact,
                                PhoneNumber = "4561374",
                                PhoneType = "Home"
                            }

                        }
                    },
                    new PhoneBookDTO
                    {
                        Contact = david,
                        AddressList = new List<AddressDTO>
                        {
                            new AddressDTO
                            {
                                IdContact = david.IdContact,
                                Address = "Av America 512",
                                City = "Cochabamba",
                                Country = "Bolivia"
                            }
                        },
                        EmailList = new List<E_MailAddressDTO>
                        {
                            new E_MailAddressDTO
                            {
                                IdContact = david.IdContact,
                                EMailAddress = "Danniel0@gmail.com",
                                EmailType = "Personal"
                            }

                        },
                        PhoneList = new List<PhoneDTO>
                        {
                            new PhoneDTO
                            {
                                IdContact = david.IdContact,
                                PhoneNumber = "6204532",
                                PhoneType = "Movile"
                            }

                        }
                    },
                    new PhoneBookDTO
                    {
                        Contact = victor,
                        AddressList = new List<AddressDTO>
                        {
                            new AddressDTO
                            {
                                IdContact = victor.IdContact,
                                Address = "Trojes y castillo",
                                City = "Santa Cruz",
                                Country = "Bolivia"
                            }
                        },
                        EmailList = new List<E_MailAddressDTO>
                        {
                            new E_MailAddressDTO
                            {
                                IdContact = david.IdContact,
                                EMailAddress = "victor@gmail.com",
                                EmailType = "Personal"
                            }

                        },
                        PhoneList = new List<PhoneDTO>
                        {
                            new PhoneDTO
                            {
                                IdContact = victor.IdContact,
                                PhoneNumber = "60478145",
                                PhoneType = "Movile"
                            }

                        }
                    },

                };
        }

        public List<PhoneBookDTO> PhoneBook { get; set; }

        public static MemoryDataRecord Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new MemoryDataRecord();
                    }
                    return _instance;
                }
            }
        }
    }
}

