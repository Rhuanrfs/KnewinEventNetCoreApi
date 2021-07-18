using System;
using System.Collections.Generic;

#nullable disable

namespace KnewinEventNetCoreApi.Model.Entities
{
    public partial class Evento
    {
        public int CodEvento { get; set; }
        public string Nome { get; set; }
        public bool? Ativo { get; set; }
        public int? CodCalendario { get; set; }

        public virtual Calendario CodCalendarioNavigation { get; set; }
    }
}
