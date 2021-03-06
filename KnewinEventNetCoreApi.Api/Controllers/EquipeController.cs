using KnewinEventNetCoreApi.Model.Busca;
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
    public class EquipeController : ControllerBase
    {
        private readonly IEquipeService _service;

        public EquipeController(IEquipeService service)
        {
            _service = service;
        }

        [HttpPost("Editar")]
        public string Editar([FromBody] Equipe equipe)
        {
            return _service.Atualizar(equipe);
        }

        [HttpPost("Incluir")]
        public string Incluir([FromBody] Equipe equipe)
        {
            return _service.Adicionar(equipe);
        }

        [HttpGet("{codigo}")]
        public Equipe Get(int codigo)
        {
            return _service.Get(codigo);
        }

        [HttpPost("Listar")]
        public List<Equipe> Listar([FromBody]BuscarEquipe buscar)
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
