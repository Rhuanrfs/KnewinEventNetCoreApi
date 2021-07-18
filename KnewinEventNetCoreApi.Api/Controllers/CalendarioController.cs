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
    [ApiController]
    [Route("[controller]")]
    public class CalendarioController : ControllerBase
    {
        private readonly ICalendarioService _service;

        public CalendarioController(ICalendarioService calendario)
        {
            _service = calendario;
        }

        [HttpPost("Editar")]
        public string Editar([FromBody] Calendario calendario)
        {
            return _service.Atualizar(calendario);
        }

        [HttpPost("Incluir")]
        public string Incluir([FromBody] Calendario calendario)
        {
            return _service.Adicionar(calendario);
        }

        [HttpGet("{codigo}")]
        public Calendario Get(int codigo)
        {
            return _service.Get(codigo);
        }

        [HttpPost("Listar")]
        public List<Calendario> Listar([FromBody] Calendario buscar)
        {
            return _service.Listar(buscar);
        }

        [HttpPost("Remover")]
        public string Remover([FromBody] int codigo)
        {
            return _service.Deletar(codigo);
        }
    }
}
