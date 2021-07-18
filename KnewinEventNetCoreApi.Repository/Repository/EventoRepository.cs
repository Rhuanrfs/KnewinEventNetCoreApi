using KnewinEventNetCoreApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnewinEventNetCoreApi.Repository.Repository
{
    public class EventoRepository
    {
        private readonly KNEWIN_EVENTContext context;

        public EventoRepository()
        {
            context = new KNEWIN_EVENTContext();
        }

        public Evento Get(int codigo) => context.Eventos.FirstOrDefault<Evento>(u => u.CodEvento == codigo);

        public IQueryable<Evento> GetAll() => context.Eventos;

        public void Adicionar(Evento evento)
        {
            context.Add(evento);
            context.SaveChanges();
        }

        public void Atualizar(Evento evento)
        {
            Evento editar = Get(evento.CodEvento);
            if (editar != null)
            {
                context.Update(evento);
                context.SaveChanges();
            }
            else
                throw new Exception("Registro não encontrado");
        }

        public void Deletar(int codigo) => context.Remove<Evento>(Get(codigo));

    }
}
