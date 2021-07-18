using KnewinEventNetCoreApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KnewinEventNetCoreApi.Repository.Repository
{
    public class EquipeRepository
    {
        private readonly KNEWIN_EVENTContext context;

        public EquipeRepository()
        {
            context = new KNEWIN_EVENTContext();
        }

        public Equipe Get(int codigo) => context.Equipes.FirstOrDefault<Equipe>(u => u.CodEquipe == codigo);

        public IQueryable<Equipe> GetAll() => context.Equipes;

        public void Adicionar(Equipe equipe)
        {
            context.Add(equipe);
            context.SaveChanges();
        }

        public void Atualizar(Equipe equipe)
        {
            Equipe editar = Get(equipe.CodEquipe);
            if (editar != null)
            {
                context.Update(equipe);
                context.SaveChanges();
            }
            else
                throw new Exception("Registro não encontrado");
        }

        public void Deletar(int codigo)
        {
            Equipe equipe = Get(codigo);
            context.Remove<Equipe>(equipe);
        }
    }
}
