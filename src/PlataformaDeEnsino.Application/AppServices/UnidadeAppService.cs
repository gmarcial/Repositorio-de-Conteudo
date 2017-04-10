using System.Collections.Generic;
using PlataformaDeEnsino.Application.AppServices.Interfaces;
using PlataformaDeEnsino.Core.Entities;
using PlataformaDeEnsino.Core.Services.Interfaces;

namespace PlataformaDeEnsino.Application.AppServices
{
    public class UnidadeAppService : AppServiceBase<Unidade, int>, IUnidadeAppService
    {
        private readonly IUnidadeService _unidadeService;

        public UnidadeAppService(IUnidadeService unidadeService) : base(unidadeService)
        {
            _unidadeService = unidadeService;
        }

        public IEnumerable<Unidade> ConsultarUnidadadesDoModulo(int idDoModulo)
        {
            return _unidadeService.ConsultarUnidadadesDoModulo(idDoModulo);
        }
    }
}