using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversios_2
{
   public class Metodo
    {
        /*aqui cree una clase llamada metodo y cree un metodo 
         que va conversion de cuantos pesos tiene que dar y tambien cuantos 
         centavos */
        public void convertir(int tcentavos,out int pesos,out int centavos)
        {
            pesos = tcentavos / 100;
            centavos = tcentavos % 100;
        }
    }
}
