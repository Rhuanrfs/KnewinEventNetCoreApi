using KnewinEventNetCoreApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KnewinEventNetCoreApi.Repository.Repository
{
    public class UsuarioRepository
    {
        private readonly KNEWIN_EVENTContext context;

        public UsuarioRepository()
        {
            context = new KNEWIN_EVENTContext();
        }

        public Usuario Get(int codigo) => context.Usuarios.FirstOrDefault<Usuario>(u => u.CodUsuario == codigo);

        public IQueryable<Usuario> GetAll(Expression<Func<Usuario, int, bool>> predicate) => context.Usuarios.Where(predicate);

        public void Adicionar(Usuario usuario)
        {
            context.Add(usuario);
            context.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            Usuario editar = Get(usuario.CodUsuario);
            if (editar != null)
            {
                context.Update(usuario);
                context.SaveChanges();
            }
            else
                throw new Exception("Registro não encontrado");
        }

        public void Deletar(Usuario usuario) => context.Remove<Usuario>(usuario);

    }
}
