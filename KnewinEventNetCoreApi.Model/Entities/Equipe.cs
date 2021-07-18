using System;
using System.Collections.Generic;

#nullable disable

namespace KnewinEventNetCoreApi.Model.Entities
{
    public partial class Equipe
    {
        public Equipe()
        {
            Calendarios = new HashSet<Calendario>();
            Usuarios = new HashSet<Usuario>();
        }

        public int CodEquipe { get; set; }
        public string Nome { get; set; }
        public bool? Ativo { get; set; }

        public virtual ICollection<Calendario> Calendarios { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
