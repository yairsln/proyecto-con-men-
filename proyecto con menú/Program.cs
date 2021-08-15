using System;

namespace proyecto_con_menú
{
    class Program
    {
        static void Main(string[] args)
        {
            principal();

        }

        static void principal()
        {
            int repetir_menu;
            System.Console.WriteLine("Estructuras de control en Visual C#");
            System.Console.WriteLine("1. Menú de opciones");
            System.Console.WriteLine("2. Salir");


            System.Console.WriteLine("Ingrese 1 para mostrar menú o 2 para salir. ");
            repetir_menu = Int32.Parse(Console.ReadLine());

            while (repetir_menu == 1)
            {
                opciones();
            }

            

        }


        static void opciones()
        {

            int opcion;

            System.Console.WriteLine("Ejemplos de estructuras de control");
            System.Console.WriteLine(" 1.  IF-ELSE  ");
            System.Console.WriteLine(" 2. While");
            System.Console.WriteLine(" 3. DoWhile ");
            System.Console.WriteLine(" 4.  For");

            System.Console.WriteLine("Ingrese la opción: ");
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    programa1();
                    break;
                case 2:
                    programa2();
                    break;
                case 3:
                    programa3();
                    break;
                case 4:
                    programa4();
                    break;
               
                default:
                    System.Console.WriteLine("Opción equivocada");
                    break;
            }
            //System.Console.ReadKey();
            principal();

        }

        static void programa1()
        {
            System.Console.WriteLine(" IF-ELSE ");
            Console.WriteLine("ingrese un numero entre 1 y 3"); 
            int num = int.Parse(Console.ReadLine()); 
            if (num == 1)
            { Console.WriteLine("valor es 1"); }
            else
            if(num == 2){ Console.WriteLine("valor es 2"); }
            else
            if(num == 3){ Console.WriteLine("valor es 3"); 
            }else { Console.WriteLine("no se encontro el valor"); }

        }

        static void programa2()
        {
            System.Console.WriteLine("While");
            Console.WriteLine("ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero mayor que el anterior");
            int num2 = int.Parse(Console.ReadLine());
            while (num1 < num2)
            { 
                Console.WriteLine("valores:" + num1); num1++; }
            Console.ReadKey();

        }

        static void programa3()
        {
            System.Console.WriteLine("DoWhile");
            string secreta; string palabra;
            Console.WriteLine("ingrese la palabra secreta");
            secreta = Console.ReadLine(); 
            do 
            {
                Console.WriteLine("vuelva a introducir la palabra secreta"); 
                palabra = Console.ReadLine();
                if 
                    (palabra != secreta) Console.WriteLine("palabra incorrecta");
            } while (palabra != secreta);
            Console.WriteLine("Palabra Correcta"); Console.ReadKey();

        }

        static void programa4()
        {
            System.Console.WriteLine(" For programa que imprima en pantalla los números del 1 al 100.");
            int f;
            for (f = 1; f <= 100; f++)
            {
                Console.Write(f);
                Console.Write("-");
            }
            Console.ReadKey();
        }

    }
}
