using KnewinEventNetCoreApi.Model.Busca;
using KnewinEventNetCoreApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnewinEventNetCoreApi.Service.IService
{
    public interface IEquipeService
    {
        string Adicionar(Equipe equipe);

        string Atualizar(Equipe equipe);

        string Deletar(int codigo);

        bool Exists(int codigo);

        Equipe Get(int codigo);

        List<Equipe> Listar(BuscarEquipe equipe);
    }
}
