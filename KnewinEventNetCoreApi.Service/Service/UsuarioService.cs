using KnewinEventNetCoreApi.Model.Entities;
using KnewinEventNetCoreApi.Repository.Repository;
using KnewinEventNetCoreApi.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnewinEventNetCoreApi.Service.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioRepository _repository;
        private readonly IEquipeService _serviceEquipe;

        public UsuarioService(IEquipeService service)
        {
            _serviceEquipe = service;
            _repository = new UsuarioRepository();
        }
        
        public string Adicionar(Usuario usuario)
        {
            try
            {
                if (ValidarUsuario(usuario))
                    return "Preencha corretamente.";

                _repository.Adicionar(usuario);
                return "Incluido com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        private bool ValidarUsuario(Usuario usuario)
        {
            return usuario.CodEquipe.HasValue && _serviceEquipe.Exists(usuario.CodEquipe.Value) && string.IsNullOrWhiteSpace(usuario.Nome);
        }

        public string Atualizar(Usuario usuario)
        {
            try
            {
                if (ValidarUsuario(usuario))
                    return "Preencha corretamente.";

                _repository.Atualizar(usuario);
                return "Atualizado com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        public string Deletar(int codigo)
        {
            try
            {
                if (codigo > 0)
                    return "Escolha um registro para a exclusão.";

                _repository.Deletar(codigo);
                return "Atualizado com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        public Usuario Get(int codigo) => _repository.Get(codigo);

        public List<Usuario> Listar(Usuario usuario) => _repository.GetAll().Where(x => (usuario.CodEquipe == null || x.CodEquipe == usuario.CodEquipe) && (x.Nome == null || x.Nome.Contains(usuario.Nome))).ToList();

    }
}
