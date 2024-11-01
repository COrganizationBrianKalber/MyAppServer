using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnXinYMinutes.Scripts
{
    




    /*
     * Operator (Suma) + se lo describe asi: "x + y"
     * Operator (Resta) - se lo describe asi: "x - y"
     * Operator (Multiplicacion) * se lo describe asi: "x * y"
     * Operator (Division) / se lo describe asi: "x / y"
     * Operator (Modulo) % se lo describe asi: "x % y"
     * Operator (Incremento) ++ se lo describe asi: "x ++"
     * Operator (Decremento) -- se lo describe asi: "x --"
    */



    class Operator 
    {
        
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
            static string myBucles(string bucleFor) 
            {

                Console.WriteLine("For Loop");
            }
                






    }
    }
}
