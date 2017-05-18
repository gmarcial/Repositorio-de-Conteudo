using System;
using System.Threading.Tasks;
using PlataformaDeEnsino.Core.Entities;
using PlataformaDeEnsino.Core.Repositories;
using PlataformaDeEnsino.Core.Services.Interfaces;

namespace PlataformaDeEnsino.Core.Services
{
    public class ProfessorService : ServiceBase<Professor>, IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;
        public ProfessorService(IProfessorRepository professorRepository) : base(professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public async Task<Professor> ConsultarPelaUnidadeAsync(int idDaUnidade)
        {
            return await _professorRepository.ConsultarPelaUnidadeAsync(idDaUnidade);
        }

        public async Task<Professor> ConsultarPeloCpfAsync(string cpfDoProfessor)
        {
            return await _professorRepository.ConsultarPeloCpfAsync(cpfDoProfessor);
        }
    }
}