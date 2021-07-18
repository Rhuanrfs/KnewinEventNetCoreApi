using KnewinEventNetCoreApi.Model.Entities;
using KnewinEventNetCoreApi.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnewinEventNetCoreApi.Service.Service
{
    public class CalendarioService
    {
        private readonly CalendarioRepository _repository;

        public CalendarioService()
        {
            _repository = new CalendarioRepository();
        }

        public string Adicionar(Calendario calendario)
        {
            try
            {
                if (Validar(calendario))
                    return "Preencha corretamente.";

                _repository.Adicionar(calendario);
                return "Incluido com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        private bool Validar(Calendario calendario)
        {
            return string.IsNullOrWhiteSpace(calendario.Nome);
        }

        public string Atualizar(Calendario calendario)
        {
            try
            {
                if (Validar(calendario))
                    return "Preencha corretamente.";

                _repository.Atualizar(calendario);
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

        public Calendario Get(int codigo) => _repository.Get(codigo);

        public List<Calendario> Listar(Calendario calendario) => _repository.GetAll().Where(x => (calendario.CodEquipe == null || x.CodEquipe == calendario.CodEquipe) && (x.Nome == null || x.Nome.Contains(calendario.Nome))).ToList();

    }
}
