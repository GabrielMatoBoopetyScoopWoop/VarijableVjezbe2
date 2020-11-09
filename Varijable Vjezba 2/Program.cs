using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_Vjezba_2
{
    class Program
    {
        struct MojStruct
        {
            public int PrviBroj, DrugiBroj;
            public char PrviChar;
            public double PrviDouble, DrugiDouble;
            public bool PrviBool;
            public string PrviString;
        }
        static void Main(string[] args)
        {
            MojStruct PrviStruct;
            PrviStruct.PrviBroj = 100;
            PrviStruct.DrugiBroj = -1000;
            PrviStruct.PrviChar = 'a';
            PrviStruct.PrviDouble = 3.123;
            PrviStruct.DrugiDouble = 3.123456789;
            PrviStruct.PrviBool = true;
            PrviStruct.PrviString = "true";
            Console.WriteLine(
            PrviStruct.PrviBroj + ", " +
            PrviStruct.DrugiBroj + ", " +
            PrviStruct.PrviChar + ", " +
            PrviStruct.PrviDouble + ", " +
            PrviStruct.DrugiDouble + ", " +
            PrviStruct.PrviBool + ", " +
            PrviStruct.PrviString);
            Console.ReadKey();
        }
    }
}
