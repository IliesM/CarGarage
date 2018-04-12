using CarGarage.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CarGarage.Models;

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
        [Route("api/Client/Register")]
        public async Task<IHttpActionResult> Register(Models.Client client)
        {
            if (client != null)
            {
                if (await _clientService.Add(client))
                {

                }
            }

        
            return Ok(client);
           
            //return InternalServerError();
        }
    }
}
