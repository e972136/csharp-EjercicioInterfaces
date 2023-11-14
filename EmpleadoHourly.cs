namespace Gaspar{
    public class EmpleadoHourly:Comportamiento {

        public String nombre;
        public double sueldo;

        public void obtenerNombre(){
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
        }
        public void obtenerSueldo(){
            Console.Write("Sueldo por hora: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
        }

         public double calcularSalario(){
            return sueldo * 44.0;
        }
    }
}