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
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuario)
        {
            _usuarioService = usuario;
        }

        [HttpGet]
        public Usuario Get(int cod_usuario)
        {
            return _usuarioService.Get(cod_usuario);
        }

        [HttpPost("Incluir")]
        public string Incluir([FromBody] Usuario usuario)
        {
            return _usuarioService.Adicionar(usuario);
        }
    }
}
