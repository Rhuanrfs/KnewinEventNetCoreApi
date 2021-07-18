using System;
using System.Collections.Generic;

#nullable disable

namespace KnewinEventNetCoreApi.Model.Entities
{
    public partial class Presenca
    {
        public int CodPresenca { get; set; }
        public int CodEvento { get; set; }
        public int CodUsuario { get; set; }

        public virtual Evento CodEventoNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
