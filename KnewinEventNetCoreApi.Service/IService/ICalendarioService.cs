using KnewinEventNetCoreApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnewinEventNetCoreApi.Service.IService
{
    public interface ICalendarioService
    {
        string Adicionar(Calendario calendario);

        string Atualizar(Calendario calendario);

        string Deletar(int codigo);

        Calendario Get(int codigo);

        List<Calendario> Listar(Calendario calendario);
    }
}
