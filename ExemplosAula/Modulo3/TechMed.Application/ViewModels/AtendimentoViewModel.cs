namespace TechMed.Application.ViewModels;

public class AtendimentoViewModel
{
    public int AtendimentoId { get; set; }
    public int MedicoId { get; set; }
    public string? MedicoNome { get; set; }
    public int PacienteId { get; set; }
    public string? PacienteNome { get; set; }
    // public DateTime DataHora { get; set; }
    // public string Descricao { get; set; }
}
