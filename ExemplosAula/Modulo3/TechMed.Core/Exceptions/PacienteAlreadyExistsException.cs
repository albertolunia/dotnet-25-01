namespace TechMed.Core.Exceptions
{
    public class PacienteAlreadyExistsException : Exception
    {
        public PacienteAlreadyExistsException() : base("Paciente ja existe")
        {
        }
    }
}
