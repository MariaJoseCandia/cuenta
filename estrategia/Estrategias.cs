using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using cuenta;

namespace banco.Estrategias
{
    class Estrategias
    {
       static List<Estrategia> Estra = new List<Estrategia>()
       {
           new Ahorro(),
           new Cauto(),
           new Emergencia(),
       };
       public static IEstrategia EstrategiaPara(Cliente cliente) => (Estra.FirstOrDefault(e => e.EsApto(cliente)));
    }
}