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
            bool resultadoOr = valor1 || valor2;// si uno de los dos es verdadero dara verdadero
            System.Console.WriteLine(resultadoOr);
            bool resultadoNegado = !valor1; //cambia el resultado a lo contrario del valor de la variable
            System.Console.WriteLine(resultadoNegado);
            bool resultadoXor = valor2 ^ valor4; // solo dara verdadero si son diferentes uno verdadero otro falso 
            System.Console.WriteLine(resultadoXor);

            //Operadores relacionales == igual que != diferente a que > mator que < menor que <= menor o igual

            bool resultadoIgualQue = valor1 == valor3; // si los dos valores son iguales dara verdadero
            System.Console.WriteLine(resultadoIgualQue);
            int item1 = 10;
            int item2 = 1;
            int item3 = 2;

            var resultadoDiferenteAQue = valor1 != valor2; // si el valor 1 es diferente al valor 2 sera verdadero
            System.Console.WriteLine(resultadoDiferenteAQue);


            string explicacion = "";
            //concatenar informacion $"bla bla bla {variable} bla bla bla {variable}"

            //Sentencias if
            int totalJugador = 22;
            int totalDealer = 15;
            string message = "";

            if (totalJugador > totalDealer && totalJugador < 22)
            {
                message = "venciste al dealer";
            }
            else if (totalJugador < totalDealer)
            {
                message = "perdiste";
            }
            else if (totalJugador > 21)
            {
                message = "perdiste te pasaste";
            }
            else
            {
                message = "condicion no valida";
            }

            System.Console.WriteLine(message);

            // sentencia switch
            string switchControl = "viernes";
            switch (switchControl) //tomara el valor de la variable que ingrese
            {
                case "lunes": // comparara la variable con cada caso si son iguales entra
                    System.Console.WriteLine("bienvenido lunes");
                    System.Console.WriteLine("Escriba 21 para jugar");
                    switchControl = Console.ReadLine();
                    break;
                case "martes":
                    System.Console.WriteLine("bienvenido martes");
                    break;
                default: //en caso que ningun caso se cumpla se va a default
                    System.Console.WriteLine("no se reconoce la instruccion");
                    break;

            }
            //sentence while?

        }
    }
}