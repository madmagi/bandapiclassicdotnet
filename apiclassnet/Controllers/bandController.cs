using apiclassnet.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace apiclassnet.Controllers
{
    public class bandController : ApiController
    {

        static readonly IBandRepository bandRepository = new BandRepository();
        // GET: api/band
        public IEnumerable<Band> Get()
        {
            return bandRepository.GetAllBands();
        }

        // GET: api/band/Jinjer
        public Band Get(string id)
        {
            return bandRepository.GetBand(id);
        }

        // POST: api/band
        public IHttpActionResult Post([FromBody]Band value)
        {
            Band band;
            band = bandRepository.AddBand(value);
            if (band != null)
            {
                return Ok(band);
            }

            return BadRequest();

        }

        // PUT: api/band/5
        public IHttpActionResult Put([FromBody]Band value)
        {
            Band band;
            band = bandRepository.UpdateBand(value);
            if (band != null)
            {
                return Ok(band);
            }

            return BadRequest();
        }

        // DELETE: api/band/Jinjer
        public IHttpActionResult Delete(string id)
        {
            if (bandRepository.DeleteBand(id))
            {
                return Ok();
            }

            return NotFound();
            
        }

        [System.Web.Http.HttpPatch]
        public void Patch(string band, int value)
        {
            bandRepository.UpdateRating(band,value);
        }



    }
}
