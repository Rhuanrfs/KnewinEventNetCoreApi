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
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoService _service;

        public EventoController(IEventoService evento)
        {
            _service = evento;
        }

        [HttpPost("Editar")]
        public string Editar([FromBody] Evento evento)
        {
            return _service.Atualizar(evento);
        }

        [HttpPost("Incluir")]
        public string Incluir([FromBody] Evento evento)
        {
            return _service.Adicionar(evento);
        }

        [HttpGet("{codigo}")]
        public Evento Get(int codigo)
        {
            return _service.Get(codigo);
        }

        [HttpPost("Listar")]
        public List<Evento> Listar([FromBody] Evento buscar)
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
