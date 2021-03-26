using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int OpcionDeEtapa = 0;
            int PesoDelPerro = 0;
            int ActividadDelPerro = 0;
            int PesoIdeal = 0;
            int EdadDelCachorro = 0;
            string TextoDeOpcion = "";

            //Filtrar cachorros y perros adultos
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("¡Bienvenido ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("a tu ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("programa de ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("nutrición ideal ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("para perros!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Para comenzar, por favor, indíquenos la etapa en la que se encuentra su perro:");
                Console.WriteLine("Opción 1 = Adulto");
                Console.WriteLine("Opción 2 = Cachorro");
                Console.WriteLine("Opción 3 = Salir del programa");
                TextoDeOpcion = Console.ReadLine();
                OpcionDeEtapa = Convert.ToInt32(TextoDeOpcion);

                //Opción de perro adulto
                if (OpcionDeEtapa == 1)

                {
                    Console.WriteLine("");
                    Console.WriteLine("A continuación, indique el peso de su perro en gramos.");
                    TextoDeOpcion = Console.ReadLine();
                    PesoDelPerro = Convert.ToInt32(TextoDeOpcion);
                    Console.WriteLine("");
                    Console.WriteLine("Procesando...");
                    Console.WriteLine("");

                    Console.WriteLine("Ahora, especifique el nivel de actividad de su perro.");
                    Console.WriteLine("1 = Alta");
                    Console.WriteLine("2 = Normal");
                    Console.WriteLine("3 = Baja");
                    TextoDeOpcion = Console.ReadLine();
                    ActividadDelPerro = Convert.ToInt32(TextoDeOpcion);

                    //Tamaño miniatura
                    if (PesoDelPerro >= 2 && PesoDelPerro <= 5)
                    {
                        switch (ActividadDelPerro)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 60-115g de alimento");
                                Console.WriteLine("");
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 55-100g de alimento");
                                Console.WriteLine("");
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 45-85g de alimento");
                                Console.WriteLine("");
                                break;
                        }
                    }

                    //Tamaño pequeño
                    if (PesoDelPerro > 5 && PesoDelPerro <= 10)
                    {
                        switch (ActividadDelPerro)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 115-190g de alimento");
                                Console.WriteLine("");
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 100-170g de alimento");
                                Console.WriteLine("");
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 85-145g de alimento");
                                Console.WriteLine("");
                                break;
                        }
                    }

                    //Tamaño mediano
                    if (PesoDelPerro > 10 && PesoDelPerro <= 15)
                    {
                        switch (ActividadDelPerro)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 190-255g de alimento");
                                Console.WriteLine("");
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 170-225g de alimento");
                                Console.WriteLine("");
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 145-195g de alimento");
                                Console.WriteLine("");
                                break;
                        }
                    }

                    //Tamaño grande
                    if (PesoDelPerro > 15 && PesoDelPerro <= 25)
                    {
                        switch (ActividadDelPerro)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 255-380g de alimento");
                                Console.WriteLine("");
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 225-330g de alimento");
                                Console.WriteLine("");
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 195-285g de alimento");
                                Console.WriteLine("");
                                break;
                        }
                     }
                    if (PesoDelPerro > 25 && PesoDelPerro <= 40)
                    {
                         switch (ActividadDelPerro)
                         {
                             case 1:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 380-535g de alimento");
                                Console.WriteLine("");
                                break;
                             case 2:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 330-475g de alimento");
                                Console.WriteLine("");
                                break;
                             case 3:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 285-410g de alimento");
                                Console.WriteLine("");
                                break;
                         }
                    }

                        if (PesoDelPerro > 40 && PesoDelPerro <= 56)
                        {
                            switch (ActividadDelPerro)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 535-680g de alimento");
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 475-600g de alimento");
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 410-520g de alimento");
                                    Console.WriteLine("");
                                    break;
                            }
                        }

                        if (PesoDelPerro > 56 && PesoDelPerro <= 70)
                        {
                            switch (ActividadDelPerro)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 680-820g de alimento");
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 600-720g de alimento");
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 520-620g de alimento");
                                    Console.WriteLine("");
                                    break;
                            }
                        }

                        if (PesoDelPerro > 70 && PesoDelPerro <= 90)
                        {
                            switch (ActividadDelPerro)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 820-985g de alimento");
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 720-870g de alimento");
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Estimado usuario, para una nutrición sana, su perro deberá consumir 620-750g de alimento");
                                    Console.WriteLine("");
                                    break;
                            }
                        }
                }

                //Opción del cachorro
                if (OpcionDeEtapa == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("A continuación indique la edad del cachorro en meses.");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Advertencia: el mínimo de edad que acepta el programa es de 2 meses y el máximo es 12 de meses.");
                    Console.ForegroundColor = ConsoleColor.White;
                    TextoDeOpcion = Console.ReadLine();
                    EdadDelCachorro = Convert.ToInt32(TextoDeOpcion);
                    Console.WriteLine("");

                    if (EdadDelCachorro > 12)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Edad inválida.");
                        Console.WriteLine("");
                        OpcionDeEtapa = 0;
                        EdadDelCachorro = 0;
                    }

                    if (EdadDelCachorro == 2 || EdadDelCachorro == 3 || EdadDelCachorro == 4 || EdadDelCachorro == 5 || EdadDelCachorro == 6 || EdadDelCachorro == 7 || EdadDelCachorro == 8 || EdadDelCachorro == 9 || EdadDelCachorro == 10 || EdadDelCachorro == 11 || EdadDelCachorro == 12)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ahora, indique el peso ideal que querrá para su cachorro.");
                        Console.WriteLine("Esta es la lista de peso ideales, por favor escoja una de ellas:");
                        Console.WriteLine("2, 5, 10, 17, 25, 32, 40, 50, 60, 70, y 90.");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Advertencia: Tiene que escoger uno que se encuentre en la lista, obligatoriamente.");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Nota: El peso de 50, no acepta la edad de 6-12 meses.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("      El peso de 60, no acepta la edad de 5 meses.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("      El peso de 70, no acepta la edad de 4 meses.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("      El peso de 90, no acepta la edad de 3 meses.");
                        TextoDeOpcion = Console.ReadLine();
                        PesoIdeal = Convert.ToInt32(TextoDeOpcion);
                    }else if (EdadDelCachorro == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Edad inválida.");
                        Console.WriteLine("");
                    }

                    //Mensaje de error
                    if (PesoIdeal == 1 || PesoIdeal == 3 || PesoIdeal == 4 || PesoIdeal == 6 || PesoIdeal == 7 || PesoIdeal == 8 || PesoIdeal == 9 || PesoIdeal == 10 || PesoIdeal == 11 || PesoIdeal == 12 || PesoIdeal == 13)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Peso ideal no válido.");
                        Console.WriteLine("");
                    }
                    else if (PesoIdeal == 14 || PesoIdeal == 15 || PesoIdeal == 16 || PesoIdeal == 18 || PesoIdeal == 19 || PesoIdeal == 20 || PesoIdeal == 21 || PesoIdeal == 22 || PesoIdeal == 23 || PesoIdeal == 24)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Peso ideal no válido.");
                        Console.WriteLine("");
                    } else if (PesoIdeal == 14 || PesoIdeal == 26 || PesoIdeal == 27 || PesoIdeal == 28 || PesoIdeal == 29 || PesoIdeal == 30 || PesoIdeal == 31 || PesoIdeal == 33 || PesoIdeal == 34 || PesoIdeal == 35)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Peso ideal no válido.");
                        Console.WriteLine("");
                    }
                    
                    if (PesoIdeal == 36 || PesoIdeal == 37 || PesoIdeal == 38 || PesoIdeal == 39 || PesoIdeal == 41 || PesoIdeal == 42 || PesoIdeal == 43 || PesoIdeal == 44 || PesoIdeal == 45 || PesoIdeal == 46)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Peso ideal no válido.");
                        Console.WriteLine("");
                    }
                    
                    if (PesoIdeal == 47 || PesoIdeal == 48 || PesoIdeal == 49 || PesoIdeal == 51 || PesoIdeal == 52 || PesoIdeal == 53 || PesoIdeal == 54 || PesoIdeal == 55 || PesoIdeal == 56 || PesoIdeal == 57)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Peso ideal no válido.");
                        Console.WriteLine("");
                    }
                    
                    if (PesoIdeal == 58 || PesoIdeal == 59 || PesoIdeal == 61 || PesoIdeal == 62 || PesoIdeal == 63 || PesoIdeal == 64 || PesoIdeal == 65 || PesoIdeal == 66 || PesoIdeal == 67 || PesoIdeal == 68)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Peso ideal no válido.");
                        Console.WriteLine("");
                    }
                    
                    if (PesoIdeal == 69 || PesoIdeal == 71 || PesoIdeal == 72 || PesoIdeal == 73 || PesoIdeal == 74 || PesoIdeal == 75 || PesoIdeal == 76 || PesoIdeal == 77 || PesoIdeal == 78 || PesoIdeal == 79)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Peso ideal no válido.");
                        Console.WriteLine("");
                    }
                    
                    if (PesoIdeal == 81 || PesoIdeal == 82 || PesoIdeal == 83 || PesoIdeal == 84 || PesoIdeal == 85 || PesoIdeal == 86 || PesoIdeal == 87 || PesoIdeal == 88 || PesoIdeal == 89)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Peso ideal no válido.");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                    }                 

                    //Tamaño miniautura 
                    if (PesoIdeal == 2)
                    {
                        switch (EdadDelCachorro)
                        {
                            case 2:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 2g, es necesario consumir 50g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 2g, es necesario consumir 60g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 2g, es necesario consumir 60g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 2g, es necesario consumir 60g de alimento.");
                                Console.WriteLine("");
                                break;
                        }

                        if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 2g, es necesario consumir 56g de alimento.");
                            Console.WriteLine("");
                        }
                    }

                    //Tamaño pequeño
                    if (PesoIdeal == 5)
                    {
                        switch (EdadDelCachorro)
                        {
                            case 2:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 5g, es necesario consumir 95g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 5g, es necesario consumir 110g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 5g, es necesario consumir 115g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 5g, es necesario consumir 115g de alimento.");
                                Console.WriteLine("");
                                break;

                        }

                        if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 5g, es necesario consumir 110g de alimento.");
                            Console.WriteLine("");
                        }
                    }

                    if (PesoIdeal == 10)
                    {
                        switch (EdadDelCachorro)
                        {
                            case 2:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 10g, es necesario consumir 156g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 10g, es necesario consumir 195g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 10g, es necesario consumir 195g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 10g, es necesario consumir 190g de alimento.");
                                Console.WriteLine("");
                                break;
                        }

                        if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 10g, es necesario consumir 185g de alimento.");
                            Console.WriteLine("");
                        }
                    }

                    //Tamaño mediano
                    if (PesoIdeal == 17)
                    {
                        switch (EdadDelCachorro)
                        {
                            case 2:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 17g, es necesario consumir 215g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 17g, es necesario consumir 265g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 17g, es necesario consumir 285g de alimento.");
                                Console.WriteLine("");
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 17g, es necesario consumir 285g de alimento.");
                                Console.WriteLine("");
                                break;
                        }

                        if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 17g, es necesario consumir 280g de alimento.");
                            Console.WriteLine("");
                        }
                    }
                }

                //Tamaño grande
                if (PesoIdeal == 25)
                {
                    switch (EdadDelCachorro)
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 25g, es necesario consumir 270g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 25g, es necesario consumir 350g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 25g, es necesario consumir 375g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 25g, es necesario consumir 375g de alimento.");
                            Console.WriteLine("");
                            break;
                    }

                    if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 25g, es necesario consumir 370g de alimento.");
                        Console.WriteLine("");
                    }                  
                }

                if (PesoIdeal == 32)
                {
                    switch (EdadDelCachorro)
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 32g, es necesario consumir 300g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 32g, es necesario consumir 400g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 32g, es necesario consumir 445g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 32g, es necesario consumir 450g de alimento.");
                            Console.WriteLine("");
                            break;
                    }

                    if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 32g, es necesario consumir 450g de alimento.");
                        Console.WriteLine("");
                    }                   
                }

                if (PesoIdeal == 40)
                {
                    switch (EdadDelCachorro)
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 40g, es necesario consumir 355g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 40g, es necesario consumir 475g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 40g, es necesario consumir 525g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 40g, es necesario consumir 530g de alimento.");
                            Console.WriteLine("");
                            break;

                    }

                    if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 40g, es necesario consumir 530g de alimento.");
                        Console.WriteLine("");
                    }
                }

                if (PesoIdeal == 50)
                {
                    switch (EdadDelCachorro)
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 50g, es necesario consumir 405g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 50g, es necesario consumir 545g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 50g, es necesario consumir 610g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 50g, es necesario consumir 625g de alimento.");
                            Console.WriteLine("");
                            break;
                    }

                    if(EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                        Console.WriteLine("");
                        OpcionDeEtapa = 0;
                        EdadDelCachorro = 0;
                    }
                }           

                if (PesoIdeal == 60)
                {
                    switch (EdadDelCachorro)
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 60g, es necesario consumir 450g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 60g, es necesario consumir 605g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 60g, es necesario consumir 685g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                            Console.WriteLine("");
                            OpcionDeEtapa = 0;
                            EdadDelCachorro = 0;
                            break;       
                    }

                    if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                        Console.WriteLine("");
                        OpcionDeEtapa = 0;
                        EdadDelCachorro = 0;
                    }
                }
                
                if (PesoIdeal == 70)
                {
                    switch (EdadDelCachorro)
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 70g, es necesario consumir 485g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 70g, es necesario consumir 670g de alimento.");
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                            Console.WriteLine("");
                            OpcionDeEtapa = 0;
                            EdadDelCachorro = 0;
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                            Console.WriteLine("");
                            OpcionDeEtapa = 0;
                            EdadDelCachorro = 0;
                            break;
                    }

                    if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                        Console.WriteLine("");
                        OpcionDeEtapa = 0;
                        EdadDelCachorro = 0;
                    } 
                }

                if (PesoIdeal == 90)
                {
                    switch (EdadDelCachorro)
                    {
                        case 2:
                            Console.WriteLine("Estimado usuario, para alcanzar el peso ideal de 90g, es necesario consumir 560g de alimento.");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                            Console.WriteLine("");
                            OpcionDeEtapa = 0;
                            EdadDelCachorro = 0;
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                            Console.WriteLine("");
                            OpcionDeEtapa = 0;
                            EdadDelCachorro = 0;
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                            Console.WriteLine("");
                            OpcionDeEtapa = 0;
                            EdadDelCachorro = 0;
                            break;
                    }

                    if (EdadDelCachorro >= 6 && EdadDelCachorro <= 12)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Error! Dato no disponible en la tabla de nutrición.");
                        Console.WriteLine("");
                        EdadDelCachorro = 0;
                        OpcionDeEtapa = 0;
                    }
                }
            } while (OpcionDeEtapa != 3);
        } 
    }
}
