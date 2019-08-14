using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agroindustrial_clase_sellada
{
    class Program
    {
        static void Main(string[] args)
        {
            leche v = new leche();
            Console.Write("ingrese litros : ");
            v.litros = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese conservante : ");
            v.conservantes = double.Parse(Console.ReadLine());
            Leche_Condensada proceso = new Leche_Condensada(); // esta forma no la idea es evitar escribir muchas instancias
                 
            Console.WriteLine(" resultad" + /*  Leche_Condensada.proceso_condensado() */ );// que sea de esta forma sin necesidad de usar static 
            Console.ReadKey();
          
        }
    }
}
