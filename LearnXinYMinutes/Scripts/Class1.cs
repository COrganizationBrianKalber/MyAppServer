/*Varias lineas para ser comentadas*/
/*
 * Hola
 */


using System;
using System.Collections.Generic;

//Fijarse para que sirve
//using System.Dynamic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using System.IO;
using System.Drawing;

// But this one is not:
//using System.Data.Entity;
// In order to be able to use it, you need to add a dll reference
// This can be done with the NuGet package manager: `Install-Package EntityFramework`



namespace LearnXinYMinutes.Scripts
{
    //Esto una funcion con un string de parametro vacio...
    //public void MethodOrClassOrOtherWhithParsableHelp (string firstParam) { }



    /*Punto importante del static void main
    The static void Main method is the entry point of a C# program. It is where the execution of a C# program starts. The Main method is a static method, which means it can be called without creating an instance of the class. The Main method is also void, which means it does not return a value.
     */
    //public static void Main(string[] args) {
    //    sbyte fooSbyte = 100;
    //    byte fooByte = 100;
    //    short fooShort = 1000;

    //    Console.WriteLine(fooSbyte);
    //    Console.WriteLine(fooByte);
    //    Console.WriteLine(fooShort);
    //}


    //Esta es una clase: internal.
    public static class Class1
    {




        //Los valores de los campos
        private static sbyte fooSbyte = 100;

        private static byte fooByte = 100;

        private static short fooShort = 1000;

        private static ushort fooUShort = 10000;

        private static int fooInt = 1;

        private static uint fooUint = 1; 














        public static void Syntax() 
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
        }


    }
}
