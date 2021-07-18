using KnewinEventNetCoreApi.Model.Entities;
using KnewinEventNetCoreApi.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnewinEventNetCoreApi.Service.Service
{
    public class EventoService
    {
        private readonly EventoRepository _repository;

        public EventoService()
        {
            _repository = new EventoRepository();
        }

        public string Adicionar(Evento evento)
        {
            try
            {
                if (Validar(evento))
                    return "Preencha corretamente.";

                _repository.Adicionar(evento);
                return "Incluido com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        private bool Validar(Evento evento)
        {
            return string.IsNullOrWhiteSpace(evento.Nome);
        }

        public string Atualizar(Evento evento)
        {
            try
            {
                if (Validar(evento))
                    return "Preencha corretamente.";

                _repository.Atualizar(evento);
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

        public Evento Get(int codigo) => _repository.Get(codigo);

        public List<Evento> Listar(Evento evento) => _repository.GetAll().Where(x => (evento.CodCalendario == null || x.CodCalendario == evento.CodCalendario) && (x.Nome == null || x.Nome.Contains(evento.Nome))).ToList();

    }
}
