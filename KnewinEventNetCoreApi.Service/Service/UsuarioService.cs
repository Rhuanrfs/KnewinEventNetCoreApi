using KnewinEventNetCoreApi.Model.Entities;
using KnewinEventNetCoreApi.Repository.Repository;
using KnewinEventNetCoreApi.Service.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnewinEventNetCoreApi.Service.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public string Adicionar(Usuario usuario)
        {
            try
            {
                if (!usuario.CodEquipe.HasValue && string.IsNullOrWhiteSpace(usuario.Nome))
                    return "Preencha corretamente o usuario.";

                _usuarioRepository.Adicionar(usuario);
                return "Usuario incluido com sucesso.";
            }
            catch
            {
                return "Não foi possivel incluir o Usuario.";
            }
        }

        public Usuario Get(int cod_usuario)
        {
            return _usuarioRepository.Get(cod_usuario);
        }
    }
}
