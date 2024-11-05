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


    //Esta es una clase: internal: Se usaria una clase interna cuando se quiere que un grupo de componentes cooperen de forma privada sin exponerse al resto del codigo de la aplicacion. Pueden ser campos, propiedades, metodos o evenetos
    //static:
    public class Class1
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


    }
}
