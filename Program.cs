using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Persona persona = new Persona();
            //persona.CalcularEdad();

            //Delegado delegado = new Delegado();
            //delegado.Votacion();

            //Empleado empleado = new Empleado();
            //empleado.Calcula_sueldo();


            //hoja 2
            //Factorial factorial = new Factorial();
            //factorial.factorial();

            //CambioLetras cambio = new CambioLetras();
            //cambio.SopaLetras();

            //Palabra_Mas_Larga palabra = new Palabra_Mas_Larga();
            //palabra.Palabra();



            //Examen apesa software

            //EmployeName name = new EmployeName()            //EmployeName name = new EmployeName()
            //{
            //    Nombre = "Nombre Empleado"
            //};

            //JavaScriptSerializer js = new JavaScriptSerializer();
            //string nombre = js.Serialize(name);

            //EmployeName objects = js.Deserialize<EmployeName>(nombre);
            //string name1 = objects.Nombre;
            //Console.WriteLine(" tu nombre es: "+name1);
            //Console.ReadKey();

            //{
            //    Nombre = "Nombre Empleado"
            //};
            //name.Nombre = Console.ReadLine();
            //DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(EmployeName));
            //MemoryStream msobj = new MemoryStream();
            //js.WriteObject(msobj, name);
            //msobj.Position = 0;
            //StreamReader sr = new StreamReader(msobj);
            //string json = sr.ReadToEnd();
            //sr.Close();
            //msobj.Close();

            //string json1 = "{Nombre: }";
            //using (var ms=new MemoryStream(Encoding.Unicode.GetBytes(json1)))
            //{
            //    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(EmployeName));
            //    EmployeName bsObj2 = (EmployeName)deserializer.ReadObject(ms);
            //    Console.Write("Name: " + bsObj2.Nombre); 

            //}


            //filehelpers filehelpers = new filehelpers();
            //var lineas = _filehelpers.GetLines("C/my/file.txt");


            //Pares_o_inpares numeros = new Pares_o_inpares();
            //numeros.numeros();
            //Console.WriteLine("Digite el año que necesita :");
            //int año = int.Parse(Console.ReadLine());
            //if (año%4==0&&(año%100!=0||año%400==0))
            //{
            //    Console.WriteLine("el año: "+año+" es bisiesto");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("el año: " + año + " no es bisiesto");
            //    Console.ReadKey();
            //}

            //Console.WriteLine("Digite su fecha en este formato: yy/mm/dd");
            //string fecha = Console.ReadLine();
            //string[] arreglo = fecha.Split('/');
            //switch (arreglo[1])
            //{
            //    case "01":
            //        Console.WriteLine(arreglo[2]+" "+"Enero"+" " + arreglo[0]);
            //        break;
            //    case "02":
            //        Console.WriteLine(arreglo[2] + " " + "Febrero" + " " + arreglo[0]);
            //        break;
            //    case "03":
            //        Console.WriteLine(arreglo[2] + " " + "Marzo" + " " + arreglo[0]);
            //        break;
            //    case "04":
            //        Console.WriteLine(arreglo[2] + " " + "Abril" + " " + arreglo[0]);
            //        break;
            //    case "05":
            //        Console.WriteLine(arreglo[2] + " " + "Mayo" + " " + arreglo[0]);
            //        break;
            //    case "06":
            //        Console.WriteLine(arreglo[2] + " " + "Junio" + " " + arreglo[0]);
            //        break;
            //    case "07":
            //        Console.WriteLine(arreglo[2] + " " + "Julio" + " " + arreglo[0]);
            //        break;
            //    case "08":
            //        Console.WriteLine(arreglo[2] + " " + "Agosto" + " " + arreglo[0]);
            //        break;
            //    case "09":
            //        Console.WriteLine(arreglo[2] + " " + "Septiembre" + " " + arreglo[0]);
            //        break;
            //    case "10":
            //        Console.WriteLine(arreglo[2] + " " + "Octubre" + " " + arreglo[0]);
            //        break;
            //    case "11":
            //        Console.WriteLine(arreglo[2] + " " + "Noviembre" + " " + arreglo[0]);
            //        break;
            //    case "12":
            //        Console.WriteLine(arreglo[2] + " " + "Diciembre" + " " + arreglo[0]);
            //        break;
            //}

            Console.WriteLine("Fecha Inicio");

            DateTime plazo1 =Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Fecha Fin");
            DateTime plazo2 = Convert.ToDateTime(Console.ReadLine());

            TimeSpan timeSpan = plazo2-plazo1;
            int dias = timeSpan.Days;


            Console.WriteLine("Plazo en dias: "+dias);
            Console.ReadKey();
        }
    }
}
