using Gaspar;

EmpleadoSalary salary = new EmpleadoSalary();
salary.obtenerNombre();
salary.obtenerSueldo();
Console.WriteLine($"Sueldo mensual: {salary.calcularSalario()}");

EmpleadoHourly hourly = new EmpleadoHourly();
hourly.obtenerNombre();
hourly.obtenerSueldo();
Console.WriteLine($"Sueldo mensual: {hourly.calcularSalario()}");