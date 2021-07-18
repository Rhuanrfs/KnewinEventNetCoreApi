using KnewinEventNetCoreApi.Model.Entities;
using KnewinEventNetCoreApi.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnewinEventNetCoreApi.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        private readonly IEquipeService _service;

        public EquipeController(IEquipeService service)
        {
            _service = service;
        }

        [HttpGet]
        public Equipe Get(int codigo)
        {
            return _service.Get(codigo);
        }

        [HttpPost("Incluir")]
        public string Incluir([FromBody] Equipe equipe)
        {
            return _service.Adicionar(equipe);
        }
    }
}
