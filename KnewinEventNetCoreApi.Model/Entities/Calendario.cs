using System;
using System.Collections.Generic;

#nullable disable

namespace KnewinEventNetCoreApi.Model.Entities
{
    public partial class Calendario
    {
        public Calendario()
        {
            Eventos = new HashSet<Evento>();
        }

        public int CodCalendario { get; set; }
        public string Nome { get; set; }
        public bool? Ativo { get; set; }
        public int? CodEquipe { get; set; }

        public virtual Equipe CodEquipeNavigation { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
    }
}
