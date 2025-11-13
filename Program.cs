
namespace SistemadeNotas
{

    public class Program
    {
        public static void Main (string [] args)
        {
            //inicializacion 
            Alumno alumno = new Alumno ("Alicia Pamela Barahona", "T32521024", "alicia_pamela@unitec.edu");
            Asignatura asignatura = new Asignatura ("Programacion II", "Ing. Roger Gurdian", "Lunes, Miercoles y Viernes"); 
            Matricula matricula = new Matricula

            {
                Alumno = alumno,
                Asignatura = asignatura
            }; 

            try
            {
                Console.WriteLine("Ingrese las 3 notas parciales: ");

                Console.Write("Nota 1 (maximo 30): ");
                double n1 = double.Parse(Console.ReadLine()); 

                Console.Write("Nota 2 (maximo 30): ");
                double n2 = double.Parse(Console.ReadLine());

                Console.Write("Nota 3 (maximo 40): ");
                double n3 = double.Parse(Console.ReadLine());

                matricula.ValidarNotas(n1, n2, n3); 

                //agregar notas 
                matricula.NotasParciales.AddRange(new List <double> { n1, n2, n3}); 

                //calcular notas
                double notaFinal = matricula.CalcularNotaFinal(); 
                double notaFinal2= matricula.CalcularNotaFinal(n1, n2, n3); 

            } //fin del try 
            finally
            {
                
            }
        }
    }

} // fin del namespace 

