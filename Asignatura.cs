
namespace SistemadeNotas
{
    public class Asignatura(string nombreAsignatura, string nombreDocente, string horario)
    {
        public string NombreAsignatura { get; set; } = nombreAsignatura;
        public string NombreDocente { get; set; } = nombreDocente;
        public string Horario { get; set; } = horario;
    } //fin del class

} //fin del container 