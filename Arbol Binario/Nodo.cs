using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    internal class Nodo
    {
        public int Valor;
        public Nodo Izquierdo, Derecho;

        public Nodo(int valor)
        {
            Valor = valor;
            Izquierdo = Derecho = null;
        }
    }
}
