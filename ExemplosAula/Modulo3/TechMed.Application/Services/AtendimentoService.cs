using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;

namespace TechMed.Application.Services.Interfaces;
public class AtendimentoService : IAtendimentoService
{
    private readonly ITechMedContext _context;
    public AtendimentoService(ITechMedContext context)
    {
    _context = context;
    }
    public List<AtendimentoViewModel> GetAll()
    {
        var atendimentos = _context.AtendimentosCollection.GetAll().Select(a => new AtendimentoViewModel
        {
            AtendimentoId = a.AtendimentoId,
            MedicoId = a.MedicoId,
            MedicoNome = a.Medico.Nome,
            PacienteId = a.PacienteId,
            PacienteNome = a.Paciente.Nome
        }).ToList();

        return atendimentos;
    }
}
