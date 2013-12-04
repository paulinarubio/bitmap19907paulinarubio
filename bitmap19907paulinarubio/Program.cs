using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitmap19907paulinarubio
{
    class Program
    {
        static void Main(string[] args)
        {
List<Byte> Bitmap = new List<Byte>();
    Bitmap[0]= 4;
    Bitmap[1] = 5;
    Bitmap[0] = 3;
    Bitmap[1] = 8; 
    Bitmap[1] = 2;

Console.WriteLine("Ingrese Numero de bytes que desea encontrar");
    int i = int.Parse(Console.ReadLine());
   for (int contador=0; contador<=5; contador++){
            foreach (byte x in Bitmap) {
                if (i == Bitmap[contador]) { Console.WriteLine("El numero esta en la posicion" + contador);
                break;
                Console.ReadLine();
                } 
    }


        }
    }
    }
}