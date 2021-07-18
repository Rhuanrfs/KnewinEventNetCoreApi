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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService usuario)
        {
            _service = usuario;
        }

        [HttpPost("Editar")]
        public string Editar([FromBody] Usuario usuario)
        {
            return _service.Atualizar(usuario);
        }

        [HttpPost("Incluir")]
        public string Incluir([FromBody] Usuario usuario)
        {
            return _service.Adicionar(usuario);
        }

        [HttpGet("{codigo}")]
        public Usuario Get(int codigo)
        {
            return _service.Get(codigo);
        }

        [HttpPost("Listar")]
        public List<Usuario> Listar([FromBody] Usuario buscar)
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
