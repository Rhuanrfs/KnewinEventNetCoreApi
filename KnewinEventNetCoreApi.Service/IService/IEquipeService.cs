using KnewinEventNetCoreApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnewinEventNetCoreApi.Service.IService
{
    public interface IEquipeService
    {
        Equipe Get(int codigo);

        string Adicionar(Equipe equipe);
    }
}
