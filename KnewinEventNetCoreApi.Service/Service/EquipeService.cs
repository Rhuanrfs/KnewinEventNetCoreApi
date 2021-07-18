using KnewinEventNetCoreApi.Model.Entities;
using KnewinEventNetCoreApi.Repository.Repository;
using KnewinEventNetCoreApi.Service.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnewinEventNetCoreApi.Service.Service
{
    public class EquipeService : IEquipeService
    {
        private readonly EquipeRepository _equipeRepository;

        public EquipeService()
        {
            _equipeRepository = new EquipeRepository();
        }

        public string Adicionar(Equipe equipe)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(equipe.Nome))
                    return "Preencha corretamente.";

                _equipeRepository.Adicionar(equipe);
                return "Incluido com sucesso.";
            }
            catch
            {
                return "Não foi possivel incluir.";
            }
        }

        public Equipe Get(int codigo)
        {
            return _equipeRepository.Get(codigo);
        }
    }
}
