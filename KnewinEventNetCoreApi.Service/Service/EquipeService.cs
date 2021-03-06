using KnewinEventNetCoreApi.Model.Busca;
using KnewinEventNetCoreApi.Model.Entities;
using KnewinEventNetCoreApi.Repository.Repository;
using KnewinEventNetCoreApi.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnewinEventNetCoreApi.Service.Service
{
    public class EquipeService : IEquipeService
    {
        private readonly EquipeRepository _repository;

        public EquipeService()
        {
            _repository = new EquipeRepository();
        }

        public string Adicionar(Equipe equipe)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(equipe.Nome))
                    return "Preencha corretamente.";

                _repository.Adicionar(equipe);
                return "Incluido com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        public string Atualizar(Equipe equipe)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(equipe.Nome))
                    return "Preencha corretamente.";

                _repository.Atualizar(equipe);
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

        public bool Exists(int codigo) => _repository.Get(codigo) != null;

        public Equipe Get(int codigo) => _repository.Get(codigo);

        public List<Equipe> Listar(BuscarEquipe equipe) => _repository.GetAll().Where(x => (equipe.Ativo == null || x.Ativo == equipe.Ativo) && (x.Nome == null || x.Nome.Contains(equipe.Nome))).ToList();

    }
}
