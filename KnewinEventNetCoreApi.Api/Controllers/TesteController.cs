using KnewinEventNetCoreApi.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnewinEventNetCoreApi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly ITeste _testeService;

        public TesteController(ITeste iTeste)
        {
            _testeService = iTeste;
        }

        [HttpGet]
        public string Get()
        {
            return _testeService.Get();
        }

    }
}
