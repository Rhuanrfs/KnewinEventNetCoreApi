using KnewinEventNetCoreApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnewinEventNetCoreApi.Service.IService
{
    public interface IEventoService
    {
        string Adicionar(Evento evento);

        string Atualizar(Evento evento);

        string Deletar(int codigo);

        Evento Get(int codigo);

        List<Evento> Listar(Evento evento);
    }
}
