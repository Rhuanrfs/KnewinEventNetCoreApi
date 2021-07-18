using System;
using System.Collections.Generic;

#nullable disable

namespace KnewinEventNetCoreApi.Model.Entities
{
    public partial class Usuario
    {
        public int CodUsuario { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Setor { get; set; }
        public decimal? Ddd { get; set; }
        public string Telefone { get; set; }
        public int? CodEquipe { get; set; }

        public virtual Equipe CodEquipeNavigation { get; set; }
    }
}
