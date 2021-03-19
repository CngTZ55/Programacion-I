using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerPrograma1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            String CaracteresDeA = "";
            String CaracteresDeE = "";
            Double Altura = 0.0;
            int Edad = 0;

            //Pidiendo información al usuario
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("¡");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("B");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("i");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("v");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("i");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("d");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("s");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" a");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("l");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" p");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("a");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("r");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("q");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("u");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.WriteLine("Antes que nada, por favor, indíquenos su edad y estatura a continuación.");
            
            //Temporizador 
            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                return 42;
            });
            t.Wait();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("¿Su estatura es de cuantos cm? Escriba la estatura de la siguiente manera: ");
            Console.WriteLine("Ejmeplo 1,60 ");
            CaracteresDeA = Console.ReadLine();
            Altura = Convert.ToDouble(CaracteresDeA);
            Console.WriteLine(" ");

            Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                return 42;
            });

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("¿Su edad es de?: ");
            CaracteresDeE = Console.ReadLine();
            Edad = Convert.ToInt32(CaracteresDeE);
            Console.WriteLine(" ");

            //Filtro de personas en función de las edades
            if (Edad >= 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Con una edad de {0} años.", Edad);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Tienes acceso a todas las atracciones para adultos. Como la La cueva encantada, la Torre T y la Mega Montaña Rusa.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("OJO:");
                Console.WriteLine(" No obstante, tienes restringido el acceso a las atracciones infantiles, como el Gusanito, el Carrucel y el Mini-Tren.");
            }
            if (Edad < 18 || Altura <= 1.60)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Con una edad de {0} años y una estatura de {1} cm.", Edad, Altura);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Solo tienes acceso a las atracciones infantiles y adolescentes, como el Gusanito, el Carrucel, el Mini-Tren y el Barco.");
               
            }
       
            Console.ReadLine();
                
        }
    }
}
