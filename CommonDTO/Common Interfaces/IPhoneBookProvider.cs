using System;
using System.Collections.Generic;
using CommonDTO.Models_DTO;

namespace CommonDTO.Common_Interfaces
{
    public interface IPhoneBookProvider
    {

        #region Contacts
        /// <summary>
        /// Obtain the list of Contact 
        /// </summary>
        /// <returns></returns>
        List<ContactDTO> GetContactList();

        /// <summary>
        /// OBtain the Contact we 
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        ContactDTO GetContact(Guid contactId);

        /// <summary>
        /// Insert A new Contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        bool InsertContact(ContactDTO contact);

        /// <summary>
        /// Update the Contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        bool UpdateContact(ContactDTO contact);

        /// <summary>
        /// Delete the contact
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        bool DeleteContact(Guid contactId);
        #endregion

        #region Phones
        /// <summary>
        /// Obtain the list of Phones belong to a Contact 
        /// </summary>
        /// <returns></returns>
        List<PhoneDTO> GetPhoneList(Guid contactId);


        /// <summary>
        /// Insert A new Phone for a Contact
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        bool InsertPhone(PhoneDTO phone);

        /// <summary>
        /// Update the Contact Phone
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        bool UpdatePhone(PhoneDTO phone);

        /// <summary>
        ///  Delete the contact Phone
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        bool DeletePhone(string phoneNumber);
        #endregion

        #region E-Mails
        /// <summary>
        /// Obtain the list of E-Mails belong to a Contact 
        /// </summary>
        /// <returns></returns>
        List<PhoneDTO> GetEmailList(Guid contactId);


        /// <summary>
        /// Insert A new E-Mails for a Contact
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool InsertEmail(E_MailAddressDTO email);

        /// <summary>
        /// Update the Contact E-Mails
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool UpdateEmail(E_MailAddressDTO email);

        /// <summary>
        /// Delete the contact E-Mails
        /// </summary>
        /// <param name="emailAdress"></param>
        /// <returns></returns>
        bool DeleteEmail(string emailAdress);
        #endregion

        #region Address
        /// <summary>
        /// Obtain the list of Address belong to a Contact 
        /// </summary>
        /// <returns></returns>
        List<PhoneDTO> GetAddressList(Guid contactId);


        /// <summary>
        /// Insert A new Address for a Contact
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        bool InsertAddress(AddressDTO address);

        /// <summary>
        /// Update the Contact Address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        bool UpdateAddress(AddressDTO address);

        /// <summary>
        /// Delete the contact Address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        bool DeleteAddress(string address);
        #endregion
    }
}
