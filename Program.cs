using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Program { 

        public static void Sistema()
        {
            string id;
            string nombre;
            int tipo;
            float horas;
            float salario_ord;
            float aumento;
            float salario_bruto;
            float deducciones;
            float salario_neto;
            
            Console.WriteLine("Digite su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite su cedula");
            id = Console.ReadLine();
            Console.WriteLine("Cuantas horas trabajo este mes");
            horas = float.Parse(Console.ReadLine());
            Console.WriteLine("Que tipo de empleado es usted\n 1-Operario\n 2-Tecnico\n 3-Profesional");
            tipo = int.Parse(Console.ReadLine());

            if(tipo == 1)
            {
                salario_ord = 2000 * horas;
                aumento = salario_ord * 0.15f;
                salario_bruto = salario_ord + aumento;
                deducciones = salario_bruto * 0.0917f;
                salario_neto = salario_bruto - deducciones;

                Console.WriteLine($"Para el empleado {nombre}, cedula {id} los datos son los siguientes:\n Ocupacion: Operario\n");
                Console.WriteLine($"Su salario por hora es 2000 colones\n Trabajo {horas} horas\n");
                Console.WriteLine("Su salario ordinario del mes es: "+ salario_ord+"colones \n");
                Console.WriteLine(" A usted le corresponde un aumento de 15%");
                Console.WriteLine($"Su salario bruto es de {salario_bruto}colones, le corresponde {deducciones} de deduccion de la CCSS y su salario neto es de {salario_neto}colones\n");
            }
            else if(tipo == 2)
            {
                salario_ord = 3000 * horas;
                aumento = salario_ord * 0.1f;
                salario_bruto = salario_ord + aumento;
                deducciones = salario_bruto * 0.0917f;
                salario_neto = salario_bruto - deducciones;

                Console.WriteLine($"Para el empleado {nombre}, cedula {id} los datos son los siguientes:\n Ocupacion: Tecnico\n");
                Console.WriteLine($"Su salario por hora es 2000 colones\n Trabajo {horas} horas\n");
                Console.WriteLine("Su salario ordinario del mes es: " + salario_ord + "colones \n");
                Console.WriteLine(" A usted le corresponde un aumento de 10%");
                Console.WriteLine($"Su salario bruto es de {salario_bruto}colones, le corresponde {deducciones} de deduccion de la CCSS y su salario neto es de {salario_neto}colones\n");
            }
            else if(tipo == 3)
            {
                salario_ord = 5000 * horas;
                aumento = salario_ord * 0.05f;
                salario_bruto = salario_ord + aumento;
                deducciones = salario_bruto * 0.0917f;
                salario_neto = salario_bruto - deducciones;

                Console.WriteLine($"Para el empleado {nombre}, cedula {id} los datos son los siguientes\n Ocupacion: Profesional\n");
                Console.WriteLine($"Su salario por hora es 2000 colones\n Trabajo {horas} horas\n");
                Console.WriteLine("Su salario ordinario del mes es: " + salario_ord + "colones \n");
                Console.WriteLine(" A usted le corresponde un aumento de 5%");
                Console.WriteLine($"Su salario bruto es de {salario_bruto}colones, le corresponde {deducciones} de deduccion de la CCSS y su salario neto es de {salario_neto}colones\n");

            }
        }
    
        static void Main(string[] args)
        {


            int opcion = 0;
            do
            {
                Console.WriteLine(" Bienvenidos al sistema de pago");
                Console.WriteLine(" Desea hacer una consulta de salario: 1-SI 2-NO");
                opcion = int.Parse(Console.ReadLine());
                Sistema();

            }
            while (opcion != 2);
        }
    }
}
