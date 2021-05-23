using System;

namespace Actividad_n_1_2do_intento
{
    class Program
    { 
        static void Main(string[] args)
        {
        
            string cadena = "";
            int inicio= 0;
            string nombre = "";
            bool encender= true; 
            int cedula;
            
            int hora = 0;
            
            string hototal= "";
            int pre = 0;
            int k = 0;
            double total;
             
            Console.WriteLine(" presione 1 para iniciar el programa");
            cadena = Console.ReadLine();
            inicio = Convert.ToInt32(cadena);
            if (inicio == 1)
            {
                encender = true;
                while (encender)
                {
                    Console.WriteLine("Ingrese el nombre del empleado");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el numero de cedula");
                    Console.WriteLine("Nota: sin puntos");
                    cadena = Console.ReadLine();
                    cedula = Convert.ToInt32(cadena);

                    Console.WriteLine("Ingrese la hora de entrada del trabajador");
                    Console.WriteLine("Nota: horario militar");
                    Console.WriteLine("El empleado entro a las:");
                    cadena = Console.ReadLine();
                    hora = Convert.ToInt32(cadena);
                    if (hora > 12)
                    {
                        hototal = hora - 12 + "PM";
                    }
                    if (hora <= 12)
                    {
                        hototal = hora + "AM";
                    }

                    Console.WriteLine("Se ha registrado correctamente el empleado " + (nombre));
                    Console.WriteLine("Numero de cedula " + (cedula));
                    Console.WriteLine("Hora de llegada: las " + (hototal));
                    if (hora > 8)
                    {
                        Console.WriteLine("*El trabajador no se le permite entrar, es muy tarde*");
                    }
                    if (hora <= 8)
                    {
                        Console.WriteLine("Bienvenido, si puede entrar");
                    }
                    Console.WriteLine("Desea saber el pago semanal del trabajador");
                    Console.WriteLine("1= si 0= no");
                    cadena= Console.ReadLine();
                    pre = Convert.ToInt32(cadena);
                    if (pre== 1)
                    {
                        Console.WriteLine("Indique la cantidad de Horas trabajadas en la semana anterior");
                        cadena = Console.ReadLine();
                        k = Convert.ToInt32(cadena);
                        total = k * 100;
                        Console.WriteLine("El Monto que se le pagara´ al empleado " + (nombre) + " es "+(total)+ "Bs.S");
                    }
                    
                    if (inicio == 0)
                        Console.WriteLine("¿desea continuar registrando?");
                    Console.WriteLine("1= si   0= no");
                    cadena = Console.ReadLine();
                    inicio = Convert.ToInt32(cadena);
                    if (inicio > 1)
                    {
                        Console.WriteLine("Opcion no solicitada");
                    }
                    if (inicio == 0)
                    {
                        encender = false;
                    }
                    

                }
            }
            if (inicio == 0)
                {
                    encender = false;
                }
            

            
            Console.WriteLine("usted decidio´ no iniciar el programa");

            Console.ReadKey();

        }
    }
}
