using System;
using System.Collections.Generic;
using PlataformaDeEnsino.Core.Entities;

namespace PlataformaDeEnsino.Core.Services.Interfaces
{
    public interface IModuloService : IServiceBase<Modulo>, IDisposable
    {
        IEnumerable<Modulo> ConsultarModulosDaTurma(int idDaTurma);
    }
}