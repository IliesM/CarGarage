using CarGarage.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CarGarage.Controllers.Client
{
    
    public class ClientController : ApiController
    {
        ClientService _clientService;

/*        ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }*/

        [HttpPost]
        [Route("Client/Register")]
        public async Task<IHttpActionResult> Register([FromBody] string payload)
        {
            //var client = JsonConvert.DeserializeObject(payload);

            /*if (client != null)
            {
                if (await _clientService.Add())
                    return Ok("Sucessfully registered");
            }*/
            return Ok(payload);
            //return InternalServerError();
        }
    }
}
