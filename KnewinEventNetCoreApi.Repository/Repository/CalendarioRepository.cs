using KnewinEventNetCoreApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnewinEventNetCoreApi.Repository.Repository
{
    public class CalendarioRepository
    {
        private readonly KNEWIN_EVENTContext context;

        public CalendarioRepository()
        {
            context = new KNEWIN_EVENTContext();
        }

        public Calendario Get(int codigo) => context.Calendarios.FirstOrDefault<Calendario>(u => u.CodCalendario == codigo);

        public IQueryable<Calendario> GetAll() => context.Calendarios;

        public void Adicionar(Calendario calendario)
        {
            context.Add(calendario);
            context.SaveChanges();
        }

        public void Atualizar(Calendario calendario)
        {
            Calendario editar = Get(calendario.CodCalendario);
            if (editar != null)
            {
                context.Update(calendario);
                context.SaveChanges();
            }
            else
                throw new Exception("Registro não encontrado");
        }

        public void Deletar(int codigo) => context.Remove<Calendario>(Get(codigo));

    }
}
