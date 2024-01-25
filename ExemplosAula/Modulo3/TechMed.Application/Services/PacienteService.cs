using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Application.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly ITechMedContext _context;

        public PacienteService(ITechMedContext context)
        {
            _context = context;
        }

        public List<PacienteViewModel> GetAll()
        {
            var pacientes = _context.PacientesCollection.GetAll().Select(p => new PacienteViewModel
            {
                Id = p.PacienteId,
                Nome = p.Nome
            }).ToList();

            return pacientes;
        }

        public PacienteViewModel? GetById(int id)
        {
            var paciente = _context.PacientesCollection.GetById(id);
            if (paciente == null)
            {
                return null;
            }
            var pacienteViewModel = new PacienteViewModel
            {
                Id = paciente.PacienteId,
                Nome = paciente.Nome
            };
            return pacienteViewModel;
        }

        public PacienteViewModel? GetByCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public int Create(NewPacienteInputModel paciente)
        {
            return _context.PacientesCollection.Create(new Paciente
            {
                Nome = paciente.Nome,
            });
        }

        public void Update(int id, NewPacienteInputModel paciente)
        {
            _context.PacientesCollection.Update(id, new Paciente
            {
                Nome = paciente.Nome,
            });
        }

        public void Delete(int id)
        {
            _context.PacientesCollection.Delete(id);
        }
    }
}
