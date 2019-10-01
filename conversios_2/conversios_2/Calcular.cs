using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversios_2
{
    //
   public  class Calcular
    {
        /*en esta clase pido los datos 
         y instacio la clase metodo para que ejecute su funcion*/
        public void Obtener()
        {
            int total_centavos, pesos=0, centavos=0;
            Metodo met = new Metodo();
            Console.WriteLine("ingrese la cantida de centavos");
            total_centavos = int.Parse(Console.ReadLine());
            met.convertir(total_centavos,out pesos,out centavos);
            Console.WriteLine("pesos : "+pesos);
            Console.WriteLine("centavos: "+ centavos);

        }
    }
}
