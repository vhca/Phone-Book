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

            //var jose = new ContactDTO
            //{
            //    Name = "Jose",
            //    LastName = "Cespedes",
            //    Phone = new List<PhoneDTO> {
            //        new PhoneDTO { PhoneNumber = "76583920", PhoneType = "Mobile" },
            //        new PhoneDTO { PhoneNumber = "54637474", PhoneType = "Home" }
            //    }

            //};

            //var david = new ContactDTO
            //{
            //    Name = "David",
            //    LastName = "Santa cruz",
            //    Phone = new List<PhoneDTO> {
            //        new PhoneDTO { PhoneNumber = "77348636", PhoneType = "Mobile" },
            //        new PhoneDTO { PhoneNumber = "44446778", PhoneType = "Home" }
            //    }
            //};
            //var victor = new ContactDTO
            //{
            //    Name = "Victor",
            //    LastName = "Cossio"

            //};

            PhoneBook = new List<PhoneBookDTO>
                {

                    new PhoneBookDTO
                    {
                        Contact = new ContactDTO
                            {
                                Name = "Victor",
                                LastName = "Cossio"
                            }
                    },
                     new PhoneBookDTO
                    {
                        Contact = new ContactDTO
                        {
                            Name = "Jose",
                            LastName = "Cespedes",
                            Phone = new List<PhoneDTO> {
                                new PhoneDTO { PhoneNumber = "76583920", PhoneType = "Mobile" },
                                new PhoneDTO { PhoneNumber = "54637474", PhoneType = "Home" }
                            }

                        }
                    },
                      new PhoneBookDTO
                    {
                        Contact =  new ContactDTO
                        {
                            Name = "David",
                            LastName = "Santa cruz",
                            Phone = new List<PhoneDTO> {
                                new PhoneDTO { PhoneNumber = "77348636", PhoneType = "Mobile" },
                                new PhoneDTO { PhoneNumber = "44446778", PhoneType = "Home" }
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

