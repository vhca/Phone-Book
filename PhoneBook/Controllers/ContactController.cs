using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CommonDTO.Common_Interfaces;
using CommonDTO.Models_DTO;
using Memory_Data_Storage;
using Microsoft.AspNet.OData;


namespace PhoneBook.Controllers
{
    public class ContactController : ODataController
    {
        private IPhoneBookProvider _phoneProvider;

        #region Contructor

        //public ContactController(IPhoneBookProvider _phoneProvider)
        //{
        //    _phoneProvider = this._phoneProvider;
        //}

        public ContactController()
        {
            _phoneProvider = new MemoryProvider();
        }

        #endregion

        #region Public API Methods
        // GET: api/v1.0/Contact
        [ResponseType(typeof(List<ContactDTO>))]
        [EnableQuery]
        public async Task<IHttpActionResult> Get(CancellationToken cancellationToken)
        {
            List<ContactDTO> contactList = _phoneProvider.GetContactList();

            return Ok(contactList.AsQueryable());
        }


        // GET: api/v1.0/Contact(xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)
        [ResponseType(typeof(ContactDTO))]
        [EnableQuery]
        public async Task<IHttpActionResult> Get([FromODataUri] Guid key, CancellationToken cancellationToken)
        {
            ContactDTO contact = _phoneProvider.GetContact(key);

            if (contact==null)
                return NotFound();

            return Ok(contact);
        }


        [ResponseType(typeof(ContactDTO))]
        [HttpPost]
        //[Route("api/v1.0/Contact")]
        public async Task<IHttpActionResult> Post([FromBody] ContactDTO conatctDto, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            bool result = _phoneProvider.InsertContact(conatctDto);

            if (result == false)
                return BadRequest("Could not add the Contact");

            return Ok();
        }

        // PUT: api/v1.0/Contact(xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)
        [ResponseType(typeof(ContactDTO))]
        [HttpPut]
        public async Task<IHttpActionResult> Put([FromODataUri] Guid key, [FromBody] ContactDTO contact, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            contact.IdContact = key;
            bool result = _phoneProvider.UpdateContact(contact);
           
            if (result == false)
                return BadRequest("Could not Update the Contact");

            return Ok();
        }

        // DELETE: api/v1.0/PersonaMaps(xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)
        public async Task<IHttpActionResult> Delete([FromODataUri] Guid key, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            bool result = _phoneProvider.DeleteContact(key);

            if (result == false)
                return BadRequest("Could not Delete the Contact");

            return Ok();
        }

        #endregion
        }
}