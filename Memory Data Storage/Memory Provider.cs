using System;
using System.Collections.Generic;
using System.Linq;
using CommonDTO.Common_Interfaces;
using CommonDTO.Models_DTO;


namespace Memory_Data_Storage
{
    public class MemoryProvider : IPhoneBookProvider
    {

        public List<ContactDTO> GetContactList()
        {
            return MemoryDataRecord.Instance.PhoneBook.Select(phoneBook => phoneBook.Contact).ToList();
        }

        public ContactDTO GetContact(Guid contactId)
        {
            return (from phoneBook in MemoryDataRecord.Instance.PhoneBook
                    where phoneBook.Contact.IdContact == contactId
                    select phoneBook.Contact).FirstOrDefault();
        }

        public bool InsertContact(ContactDTO contact)
        {
            var contactExist = (from phoneBook in MemoryDataRecord.Instance.PhoneBook
                                where phoneBook.Contact.IdContact == contact.IdContact
                                select phoneBook.Contact).FirstOrDefault();

            if (contactExist != null)
                return false;
            else
            {
                MemoryDataRecord.Instance.PhoneBook.Add(new PhoneBookDTO
                {
                    Contact = contact,
                    AddressList = new List<AddressDTO>(),
                    EmailList = new List<E_MailAddressDTO>(),
                    PhoneList = new List<PhoneDTO>()

                });
                return true;
            }
        }

        public bool UpdateContact(ContactDTO contact)
        {
            var contactExist = (from phoneBook in MemoryDataRecord.Instance.PhoneBook
                                where phoneBook.Contact.IdContact == contact.IdContact
                                select phoneBook.Contact).FirstOrDefault();

            if (contactExist == null)
                return false;

            foreach (var phoneBook in MemoryDataRecord.Instance.PhoneBook)
            {
                if (phoneBook.Contact.IdContact == contact.IdContact)
                {
                    phoneBook.Contact.Name = contact.Name;
                    phoneBook.Contact.LastName = contact.LastName;
                    phoneBook.Contact.BirdtDate = contact.BirdtDate;
                    return true;
                }

            }
            return false;
        }

        public bool DeleteContact(Guid contactId)
        {
            int index = 0;
            foreach (var phoneBook in MemoryDataRecord.Instance.PhoneBook)
            {
                if (phoneBook.Contact.IdContact == contactId)
                {
                    MemoryDataRecord.Instance.PhoneBook.RemoveAt(index);
                    return true;
                }
                index++;
            }
          
           return false;
        }

        public List<PhoneDTO> GetPhoneList(Guid contactId)
        {
            throw new NotImplementedException();
        }

        public bool InsertPhone(PhoneDTO phone)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePhone(PhoneDTO phone)
        {
            throw new NotImplementedException();
        }

        public bool DeletePhone(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public List<PhoneDTO> GetEmailList(Guid contactId)
        {
            throw new NotImplementedException();
        }

        public bool InsertEmail(E_MailAddressDTO email)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmail(E_MailAddressDTO email)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmail(string emailAdress)
        {
            throw new NotImplementedException();
        }

        public List<PhoneDTO> GetAddressList(Guid contactId)
        {
            throw new NotImplementedException();
        }

        public bool InsertAddress(AddressDTO address)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAddress(AddressDTO address)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAddress(string address)
        {
            throw new NotImplementedException();
        }
    }
}
