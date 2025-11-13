
namespace SistemadeNotas
{
    public class Alumno(string nombre, string numeroCuenta, string email)
    {
        public string Nombre { get; set; } = nombre;
        public string NumeroCuenta { get; set; } = numeroCuenta;
        public string Email { get; set; } = email;
    } //fin del class 
} //fin del container 