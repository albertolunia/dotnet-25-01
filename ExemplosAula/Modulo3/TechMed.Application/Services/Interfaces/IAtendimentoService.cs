using TechMed.Application.ViewModels;
namespace TechMed.Application.Services.Interfaces;

public interface IAtendimentoService
{
    public List<AtendimentoViewModel> GetAll();
    // public AtendimentoViewModel? GetById(int id);
    // public int Create(NewAtendimentoInputModel atendimento);
    // public void Update(int id, NewAtendimentoInputModel atendimento);
    // public void Delete(int id);
}
