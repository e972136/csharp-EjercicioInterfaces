namespace Gaspar{
    public class EmpleadoSalary:Comportamiento {

        public String nombre;
        public double sueldo;

        public void obtenerNombre(){
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
        }
        public void obtenerSueldo(){
            Console.Write("Sueldo Diario: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
        }

         public double calcularSalario(){
            return sueldo * 30.0;
        }
    }
}