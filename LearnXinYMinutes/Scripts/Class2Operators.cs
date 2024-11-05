using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    BIG O:
        ¿Qué es Big O?
        Notacion Big O.
            - Representa la complejidad del peor de los casos de un algoritmo. Utiliza terminos algebraicos para describir la complejidad de un algoritmo.
            
            - El Big O define el tiempo de ejecucion necesario para ejecutar un algoritmo identificando como cambiara el rendimiento de su algoritmoa medida que crece el tamano de la entrada. Pero no le dice que tan rapido es el tiempo de ejecucion de su algoritmo.

        En notacion Big O, existen 6 tipos de complejidades (tiempo y espacio):
        
        - Constante: O(1)
        - Lineal: O(n)
        - Logaritmica: O(n log n)
        - Cuadratica: O(n^2)
        - Exponencial: O(2^n)
        - Factorial: O(n!)

        En el grafico de esta URL: https://www.freecodecamp.org/espanol/news/hoja-de-trucos-big-o/ dice que O(1), complejidad de tiempo constante, es el mejor. Esto implica que su algoritmo procesa solo una declaracion sin ninguna interacion. Luego esta O(log n), que es bueno, y otros similares:
          
          - O(1) - Excelente/Mejor
          - O(log n) - Bueno
          - O(n) - Aceptable
          - O(n log n) - Malo
          - O(n^2), O(2^n) y O(n!) - Horrible/Peor








    Anagrama
    Un anagrama es una palabra creada a partir de ka reordenacion de las letras de otras palabras. Ej: saco - caso.
    Dado un array de strings, devuelve los anagramas agrupados. Cualquier orden es valido.
    
    Ejemplo:
        Input: words = ["saco", "arresto", "programa", "rastreo", "caso"].
        Output: [["saco", "caso"],["arresto","rastreo"], ["programa"]]
    */

















//Tareas :
//Crear luego y utilizar los const y constructores

//Fijarse como utilizar esto tambien
// >> double[] = new double [n] 











namespace LearnXinYMinutes.Scripts
{
    




   



    class Operator 
    {




        //Los valores de los campos
        sbyte fooSbyte = 100;

        byte fooByte = 100;

        short fooShort = 1000;

        ushort fooUShort = 10000;

        int fooInt = 1;

        uint fooUint = 1;

        long fooLong = 100000L;

        ulong fooUlong = 100000L;

        double fooDouble = 123.4;

        float fooFloat = 234.5f;

        decimal fooDecimal = 150.3m;

        bool fooBoolean = true;

        char fooChar = 'A';



        string fooString = "\"escape\" quotes and add \n (new lines) and \t (tabs)";




        // You can access each character of the string with an indexer:
        // private static char charFromString = fooString[1]; // => 'e'
        // Strings are immutable: you can't do fooString[1] = 'X';

        // Compare strings with current culture, ignoring case
        //string.Compare(fooString, "x", StringComparison.CurrentCultureIgnoreCase);

        // Formatting, based on sprintf
        string fooFs = string.Format("Check Check, {0} {1}, {0} {1:0.0}", 1, 2);

        // Dates & Formatting
        DateTime fooDate = DateTime.Now;


        // Verbatim String
        // You can use the @ symbol before a string literal to escape all characters in the string
        string path = "C:\\Users\\User\\Desktop";
        string verbatimPath = @"C:\Users\User\Desktop";


        // You can split a string over two lines with the @ symbol. To escape " use ""
        string bazString = @"Here's some stuff
                on a new line! ""Wow!"", the masses cried";

        //Esto es cuando no se puede cambiar y esta asi de por defecto
        const int HoursWorkPerWeek = 9001;















        ///////////////////////////////////////
        // Console Output.
        ///////////////////////////////////////

        public void Syntax()
        {
            // Use Console.WriteLine to print lines
            Console.WriteLine("");

            Console.WriteLine(
                    "Integer: " + 10 +
                    " Double: " + 3.14 +
                    " Boolean: " + true);

            //Para imprimir en lineas separadas
            Console.Write("Hello ");
            Console.Write("World");


            //Imprimiendo las variables campos de arriba
            //El $ es un formato como en Python de (f"{asd}")
            Console.WriteLine($"fooSbyte: {fooSbyte}");
            Console.WriteLine($"fooByte: {fooByte}");
            Console.WriteLine($"fooShort: {fooShort}");
            Console.WriteLine($"fooShort: {fooUShort}");


            //String
            //Console.WriteLine(fooString);
            //
            //Console.WriteLine(path == verbatimPath);  // => true
            //Console.WriteLine(fooDate.ToString("hh:mm, dd MMM yyyy"));

            //Console.WriteLine("intList at 0: " + intList[0]);




        }














        /*
    * Operator (Suma) + se lo describe asi: "x + y"
    * Operator (Resta) - se lo describe asi: "x - y"
    * Operator (Multiplicacion) * se lo describe asi: "x * y"
    * Operator (Division) / se lo describe asi: "x / y"
    * Operator (Modulo) % se lo describe asi: "x % y"
    * Operator (Incremento) ++ se lo describe asi: "x ++"
    * Operator (Decremento) -- se lo describe asi: "x --"
        */


        static void Main(string[] args) {

            //Type Casting: Es cuando asignas un valor de dato a otro tipo de dato. Como esto:
            Console.WriteLine("Esto es Type Casting");
            int MyInt = 9;
            string cadena = " 9";
            bool myBool = true;
            Console.WriteLine(Convert.ToString(MyInt));
            Console.WriteLine(Convert.ToInt64(cadena));
            Console.WriteLine(Convert.ToString(myBool));

            double myDouble = MyInt;
            Console.WriteLine(myDouble + cadena);
            string myString = cadena;













            //Arithmetic Operators
            int i1 = 1;
            int i2 = 2;

            
            Console.WriteLine("Arithmetic Operators 1");
            Console.WriteLine(i1 + i2);
            Console.WriteLine(i2 - i1);
            Console.WriteLine(i1 * i2);
            Console.WriteLine(i2 / i1);
            Console.WriteLine(i1 % i2);
            Console.WriteLine(i2 ++);
            Console.WriteLine(i1 --);
            Console.WriteLine("Assignment Operators");
            Console.WriteLine(i1 = 3);
            Console.WriteLine(i2 += i1);
            Console.WriteLine(i1 -= i2);
            Console.WriteLine(i1 *= i2);
            Console.WriteLine(i2 /= i1);
            //Console.WriteLine(i1 %= i2);
            Console.WriteLine(i2 &= i1);
            Console.WriteLine(i1 |= i2);
            Console.WriteLine(i2 ^= i1);
            Console.WriteLine(i1 >>= i2);
            Console.WriteLine(i2 <<= i1);


            //Assignment Operators
            Console.WriteLine("Assignment Operators 2");
            int miVariableInt = 3;


            //miVariableInt += 1;
            miVariableInt -= 3;
            Console.WriteLine(miVariableInt);



            Console.WriteLine("Comparison Operators 3");
            int x1 = 5;
            int y2 = 3;
            Console.WriteLine(x1 > y2); // returns True because 5 is greater than 3

            Console.WriteLine(x1 < y2);
            Console.WriteLine(x1 != y2);
            Console.WriteLine(x1 >= y2);
            Console.WriteLine(x1 <= y2);
            int x = 5;
            int y = 3;
            Console.WriteLine(x == y);  // returns False because 5 is not equal to 3




            Console.WriteLine("Logical Operators 4");


            int z = 5;
            Console.WriteLine(z > 3 && x < 10);
            Console.WriteLine(z < 5 || z < 4);
            Console.WriteLine(!(z > 3 && z < 10));
            Console.WriteLine(!(z > 10 || z < 4));

            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.Read();

            if (z > 18)
            {
                Console.WriteLine($"El valor:{z} mayor que 18.");
            }
            else if(z == 18) 
            {
                Console.WriteLine($"El valor:{z} es igual que 18.");
            }
            else
            {
                Console.WriteLine($"El valor:{z} es menor que 18.");
            }




            Console.WriteLine("if, else, else if ");
            int time = 20;
            //if (time < 18)
            //{
            //Console.WriteLine("Good day.");
            //}
            //else
            //{
            //Console.WriteLine("Good evening.");
            //}
            
            
            Console.WriteLine("Ternary Operator");
            //Short-hand if...else(Ternary Operator)
            //Syntax =
            //  variable = (condition) ? expressionTrue : expressionFalse;
            int time1 = 40;
            string result = (time1 < 18) ? "Good Day!" : "Good Evenning";
            Console.WriteLine(result);

            //El analisis es asi: es time1 menor que 20. No es menor que 20 entonces es el 1 que es el else de la condicion sino iria el 2 que es el if 

            int result2 = (time1 < 20) ? 2 : 1;
            Console.WriteLine(result2);

            Console.WriteLine("Math");
            Math.Sqrt(64);
            Console.WriteLine(Math.Sqrt(64));

            Console.WriteLine("Switch Statements");
            /*
            Syntax =
            Se ejecuta mucho mas rapido porque no tiene que leer todo el resto del codigo sino el que le sirve nomas.
                switch(expression)
                {
                    case x:
                        //code block
                        break;
                    case y:
                        //code block
                        break;
                    default: //En el caso de usar la keyword es opcional si no hay en el codigo ningun caso de mayusculas ni minusculas.
                        //code block
                        break;
                }
            */

            int day = 8;
            int month = 12;
            int year = 1;

            switch (day) 
            {
                case 01:
                    Console.WriteLine("Dia: Lunes");
                    if (day < 1)
                    {
                        Console.WriteLine("Estas son tus primeras horas");
                    }
                    else if (!(day < 2))
                    {
                        Console.WriteLine("Haz completado 1 dia");  
                    }
                    break;

                case 02:
                    Console.WriteLine("Dia: Martes");
                    if (day < 2)
                    {
                        Console.WriteLine("Estas en lo que queda de un comienzo");
                    }
                    else if (!(day < 3))
                    {
                        Console.WriteLine("Haz completado 1 dia");
                    }
                    break;

                case 03:
                    Console.WriteLine("Dia: Miercoles");
                    if (day < 3)
                    {
                        Console.WriteLine("Estas en lo que queda de un comienzo");
                    }
                    else if (!(day < 4))
                    {
                        Console.WriteLine("Haz completado 1 dia");
                    }
                    break;

                case 04:
                    Console.WriteLine("Dia: Miercoles");
                    if (day < 4)
                    {
                        Console.WriteLine("Estas en lo que queda de un comienzo");
                    }
                    else if (!(day < 5))
                    {
                        Console.WriteLine("Haz completado 1 dia");
                    }
                    break;

                case 05:
                    Console.WriteLine("Dia: Miercoles");
                    if (day < 5)
                    {
                        Console.WriteLine("Estas en lo que queda de un comienzo");
                    }
                    else if (!(day < 6))
                    {
                        Console.WriteLine("Haz completado 1 dia");
                    }
                    break;

                case 06:
                    Console.WriteLine("Dia: Miercoles");
                    if (day < 6)
                    {
                        Console.WriteLine("Estas en lo que queda de un comienzo");
                    }
                    else if (!(day < 7))
                    {
                        Console.WriteLine("Haz completado 1 dia");
                    }
                    break;

                case 07:
                    Console.WriteLine("Dia: Miercoles");
                    if (day < 7)
                    {
                        Console.WriteLine("Estas en lo que queda de un comienzo");
                    }
                    else if (!(day < 8))
                    {
                        Console.WriteLine("Haz completado 1 dia");
                    }
                    break;

                default:
                    Console.WriteLine("Haz completado 1 semana");
                    if (day == 8)
                    {
                        Console.WriteLine("Estas en lo que queda de un comienzo");
                    }
                    break;




            



            }
            
            //Sintaxis para llamar a un metodo o una funcion y luego como llamar a una clase

            //myObject.myBucles(string);
            //myBucles(string);




        }
        static void myBucles(string bucleFor)
        {
            Console.WriteLine("For Loop");
            //Syntax:
            /*
             * for(statement 1; statement 2; statement 3) 
             * {
             * }
             */
            //string cadena = "Cadena";
            for ( /* 1 */ int i = 0; /* 2 */ i < 5; /* 3 */ i ++);
            
            //Fijarse para que sirve esto!
            
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }


            
        }
    }
}
