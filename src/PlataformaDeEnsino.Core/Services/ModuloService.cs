using System.Collections.Generic;
using PlataformaDeEnsino.Core.Entities;
using PlataformaDeEnsino.Core.Repositories;

namespace PlataformaDeEnsino.Core.Services.Interfaces
{
    public class ModuloService : ServiceBase<Modulo, int>, IModuloService
    {
        private readonly IModuloRepository _moduloRepository;

        public ModuloService(IModuloRepository moduloRepository) : base(moduloRepository)
        {
            _moduloRepository = moduloRepository;
        }

        public IEnumerable<Modulo> ConsultarModulosDaTurma(int idDaTurma)
        {
            return _moduloRepository.ConsultarModulosDaTurma(idDaTurma);
        }
    }
}