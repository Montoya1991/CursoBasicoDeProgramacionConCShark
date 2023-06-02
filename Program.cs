using System;

namespace primerCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Datos primitivos
            int numeros; //positivos y negativos
            bool VerdadMentira;
            float NumerosConDecimales; // de 6 a 7 Digitos
            double NumerosConDecimalesTambien; // hasta 15 numeros 
            char unaPalabra;
            string VariasPalabras;
            long cadenaLargaDeNumeros; //positivos y negativos
            uint cadenaNumerosSoloPositivos; //0 a 4294967295

            //variables
            //calcular el area de un rectangulo numeros enteros 
            int ladoA; // una variable es un campo donde se almacenara una informacion
            int ladoB; // en c# va primero el tipo de variable que sera la variable y el nombre de la variable
            int resultado;
            System.Console.WriteLine("Calcula el lado de un rectangulo");
            System.Console.WriteLine("ingresa el valor del lado A");
            ladoA = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("ingresa el valor del lado b");
            ladoB = Convert.ToInt32(Console.ReadLine());
            resultado = ladoA * ladoB;
            System.Console.WriteLine("el area del rectangulo es: " + resultado);
            //_________________________________________________________________
            // las variables siempre su nombre iniciara por minuscula           
            double ladoC; // una variable es un campo donde se almacenara una informacion
            double ladoD; // en c# va primero el tipo de variable que sera la variable y el nombre de la variable
            double resultado2;
            System.Console.WriteLine("Calcula el lado de un rectangulo");
            System.Console.WriteLine("ingresa el valor del lado c");
            ladoC = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("ingresa el valor del lado d");
            ladoD = Convert.ToDouble(Console.ReadLine());
            resultado2 = ladoC * ladoD;
            System.Console.WriteLine("el area del rectangulo2 es: " + resultado2);
            //_________________________________________________________________
            //Uso reservado de la variable var 
            var DatoX = "Var tomara el tipo string";
            System.Console.WriteLine("bienvenido, calcular circulos");
            System.Console.WriteLine("Ingrese el valor del radio");
            var radio = Convert.ToDouble(Console.ReadLine());
            var resultado3 = Math.PI * radio * radio;
            System.Console.WriteLine("El area de tu circulo es de: " + resultado3);

            //Constantes siempre empezara su nombre por mayuscula
            const double Pi = 3.14;

            //operadores arimeticos
            ladoA++; // este operador suma 1 a la variable
            ladoB--; // este operador resta 1 a la variable

            System.Console.WriteLine(ladoA);

            //operadores logicos
            //&& and || or ! negacion ^
            bool valor1 = true;
            bool valor2 = false;
            bool valor3 = true;
            bool valor4 = false;

            bool resultadoAnd = valor4 && valor2; // solo sera verdadero si ambos son verdaderos
            System.Console.WriteLine(resultadoAnd);
            bool resultadoOr = valor1 || valor2;
            System.Console.WriteLine(resultadoOr);

        }
    }
}