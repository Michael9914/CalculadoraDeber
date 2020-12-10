using System;
using Calculadora;
namespace Deber1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiere utilizar la calculadora?");
            var respuesta = Console.ReadLine();
            while(respuesta!="no")
            {
                Console.WriteLine("Escoja una opcion:" +
                    " \n 1)Suma" +
                    " \n 2)Resta" +
                    " \n 3)Multiplicacion" +
                    " \n 4)Division" +
                    " \n 5)La inversa de un numero" +
                    " \n 6)El cuadrado de un numero" +
                    " \n 7)Raiz Cuadrada");

                var operacion = Console.ReadLine();
                if(operacion == "1")
                {
                    Console.WriteLine("Ingrese el primer numero");
                    var numero1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo numero");
                    var numero2 = Console.ReadLine();

                    var calculadora = new calapp();

                    var sumaTotal = calculadora.Sumar(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El resultado de la suma es:" + sumaTotal);
                }
                if (operacion == "2")
                {
                    Console.WriteLine("Ingrese el primer numero");
                    var numero1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo numero");
                    var numero2 = Console.ReadLine();

                    var calculadora = new calapp();

                    var resta = calculadora.Restar(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El resultado de la resta es:" + resta);
                }
                if (operacion == "3")
                {
                    Console.WriteLine("Ingrese el primer numero");
                    var numero1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo numero");
                    var numero2 = Console.ReadLine();

                    var calculadora = new calapp();

                    var multiplicar = calculadora.Multiplicar(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El resultado de la multiplicación es:" + multiplicar);
                }
                if (operacion == "4")
                {
                    Console.WriteLine("Ingrese el primer numero");
                    var numero1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo numero");
                    var numero2 = Console.ReadLine();

                    var calculadora = new calapp();

                    var dividir = calculadora.Dividir(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El resultado de la división es:" + dividir);
                }
                if (operacion == "5")
                {
                    Console.WriteLine("Ingrese el numero para la inversa");
                    var numero = Console.ReadLine();
                    
                    var calculadora = new calapp();

                    var inversa = calculadora.Inversa(double.Parse(numero));

                    Console.WriteLine("La inversa del número " + numero + " es: " + inversa);
                }
                if (operacion == "6")
                {
                    Console.WriteLine("Ingrese el numero para su cuadrado");
                    var numero = Console.ReadLine();
                    
                    var calculadora = new calapp();

                    var cuadrado = calculadora.Cuadrado(int.Parse(numero));

                    Console.WriteLine("El cuadrado del número " + numero + " es: " + cuadrado);
                }
                if (operacion == "7")
                {
                    Console.WriteLine("Ingrese el numero para la raiz cuadrada");
                    var numero = Console.ReadLine();

                    var calculadora = new calapp();

                    var raiz = calculadora.Raiz(int.Parse(numero));

                    Console.WriteLine("la raiz del numero " + numero + " es: " + raiz);
                }

                Console.WriteLine("Desea utilizar nuevamente la calculadora");
                respuesta = Console.ReadLine();
            }
        }
    }
}
