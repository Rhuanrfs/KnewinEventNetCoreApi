using KnewinEventNetCoreApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnewinEventNetCoreApi.Service.IService
{
    public interface IUsuarioService
    {
        Usuario Get(int cod_usuario);

        string Adicionar(Usuario usuario);
    }
}
