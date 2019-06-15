using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using CommonDTO.Common_Interfaces;
using CommonDTO.Models_DTO;
using Memory_Data_Storage;
using Microsoft.Data.OData;

namespace PhoneBook.Controllers
{
    
    public class PhoneController : ODataController
    {
        private IPhoneBookProvider _phoneProvider;

        #region Contructor
        public PhoneController()
        {
            _phoneProvider = new MemoryProvider();
        }
        #endregion

        #region Public API Methods
        // GET: api/v1.0/Phone(xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)
        [HttpGet]
        [ResponseType(typeof(List<PhoneDTO>))]
       // [Route(" api/v1.0/Phone/IdPhone/{ID}")]
        [EnableQuery]
        public async Task<IHttpActionResult> Get(CancellationToken cancellationToken)
        {
            //ContactDTO contact = _phoneProvider.GetContact(key);
            List<PhoneDTO> phoneList = _phoneProvider.GetPhoneList(new Guid());
            return Ok(phoneList.AsQueryable());
        }

        #endregion










        // GET: odata/Phone(5)
        public IHttpActionResult GetPhoneDTO([FromODataUri] System.Guid key, ODataQueryOptions<PhoneDTO> queryOptions)
        {
            // validate the query.
            try
            {
                //queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<PhoneDTO>(phoneDTO);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Phone(5)
        public IHttpActionResult Put([FromODataUri] System.Guid key, Delta<PhoneDTO> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(phoneDTO);

            // TODO: Save the patched entity.

            // return Updated(phoneDTO);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Phone
        public IHttpActionResult Post(PhoneDTO phoneDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(phoneDTO);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Phone(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] System.Guid key, Delta<PhoneDTO> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(phoneDTO);

            // TODO: Save the patched entity.

            // return Updated(phoneDTO);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Phone(5)
        public IHttpActionResult Delete([FromODataUri] System.Guid key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}