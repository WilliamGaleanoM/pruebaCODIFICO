using AreasGeometria.Models;
using System;

namespace AreasGeometria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input_radio;
            string input_base;
            string input_altura;

            //En caso de ejecutar con parametros se hace la validación y se reciben los valores requeridos (UNIT TEST)
            if ((args ?? Array.Empty<string>()).Length > 0)
            {
                string tipo = args[0];
                switch (tipo)
                {
                    case "1":
                        if (args.Length != 2)
                        {
                            throw new Exception("deben ser 2 parametros para el area del círculo");
                        }
                        input_radio = args[1];                       
                        CalcularAreaCirculo(input_radio);                       
                        break;
                    case "2":
                        if (args.Length != 3)
                        {
                            throw new Exception("deben ser 3 parametros para el area del rectángulo");
                        }
                        input_base = args[1];
                        input_altura = args[2];
                        CalcularAreaRectangulo(input_base, input_altura);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"{tipo} no es una opción valida");
                        break;
                }
            }
            else
            {

            Loop:
                char input = PedirDatos().KeyChar;

                switch (input)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Digite el radio del círculo");
                        input_radio = Console.ReadLine();                  
                        CalcularAreaCirculo(input_radio);
                        Console.ReadLine();
                        goto Loop;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Dígite la base del rectángulo");
                        input_base = Console.ReadLine();
                        Console.WriteLine("Dígite la altura del rectángulo");
                        input_altura = Console.ReadLine();                        
                        CalcularAreaRectangulo(input_base, input_altura);                        
                        Console.ReadLine();
                        goto Loop;
                    default:
                        Console.Clear();
                        Console.WriteLine($"{input} no es una opción valida");
                        goto Loop;
                }

            }
  
            
        }

        static void CalcularAreaCirculo(string input_radio)
        {
            if (double.TryParse(input_radio, out double _radio))
            {
                Circulo circulo = new() { Radio = _radio };
                Console.WriteLine($"El área del círculo es {circulo.GetArea()}");
            }
            else
            {
                Console.WriteLine("el radio del círculo debe ser un número");
            }           
        }

        static void CalcularAreaRectangulo(string input_base , string input_altura)
        {
            if (double.TryParse(input_base, out double _base) && double.TryParse(input_altura, out double _altura))
            {
                Rectangulo rectangulo = new() { Base = _base, Altura = _altura };
                Console.WriteLine($"El área del rectángulo es {rectangulo.GetArea()}");
            }
            else
            {
                Console.WriteLine("tanto la altura como la base del rectángulo deben ser números");
            }           
        }

        static ConsoleKeyInfo PedirDatos()
        {
            Console.WriteLine("Que Figura desea calcular?");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Rectángulo");
            return Console.ReadKey();
        }
    }
}
