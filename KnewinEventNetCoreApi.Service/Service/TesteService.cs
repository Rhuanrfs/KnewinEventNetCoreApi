using KnewinEventNetCoreApi.Service.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnewinEventNetCoreApi.Service.Service
{
    public class TesteService : ITesteService
    {
        public string Get() => "Teste OK";

    }
}
