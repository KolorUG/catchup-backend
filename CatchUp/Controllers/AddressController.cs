using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatchUp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Address : ControllerBase
    {
        private readonly IAddressRepository _addressReposity;

        public Address(IAddressRepository addressRepository)
        {
            _addressReposity = addressRepository;
        }
        
        [HttpPost]
        public ActionResult Add([FromBody]Address address)
        {
            
        }
    }
}
