using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lkt16_CSharp_MasterClass_Datentypen_u_Variablen
{
    class Program
    {
        static void Main(string[] args)
        {
            //primitive Datentypen
            bool myFileIsSaved = true;
            byte myByte = 2;
            char myChar = (char)006;
            int myInt = 36633;
            float myFloat = 55.66f;
            double myDouble = 6000.999;
            decimal myDecimal = 36;
            long myLong = 6123456789;
            sbyte mySbyte = 112;
            short myShort = 31000;
            uint myUint = 2123456789;
            ulong myUlong = 9123123123;
            ushort myUshort = 32000;

            //string Werte
            string TxtControl = "Ich kontrolliere den Text";
            string strZahl = "2021";   // Ganzzahl als StringWert

            //Parse_Methode
            int intZahl = int.Parse(strZahl);

            //Ausgabe
            Console.WriteLine(myFileIsSaved);
            Console.WriteLine(myByte);
            Console.WriteLine(myChar);
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);
            Console.WriteLine(myLong);
            Console.WriteLine(mySbyte);
            Console.WriteLine(myShort);
            Console.WriteLine(myUint);
            Console.WriteLine(myUlong);
            Console.WriteLine(myUshort);
            Console.WriteLine(TxtControl);
            Console.WriteLine(strZahl);
            Console.ReadKey();
        }
    }
}
