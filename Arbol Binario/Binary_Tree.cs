using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    internal class Binary_Tree
    {
        private Nodo raiz;

        public Binary_Tree()
        {
            raiz = null;
        }

        // Insertar un valor en el árbol
        public void Insertar(int valor)
        {
            raiz = InsertarRecursivo(raiz, valor);
        }

        private Nodo InsertarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                Console.WriteLine($"Insertando {valor}");
                return new Nodo(valor);
            }

            if (valor < nodo.Valor)
            {
                Console.WriteLine($"Moviendo a la izquierda para insertar {valor}");
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
            }
            else if (valor > nodo.Valor)
            {
                Console.WriteLine($"Moviendo a la derecha para insertar {valor}");
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);
            }

            return nodo;
        }

        // Buscar un valor en el árbol
        public bool Buscar(int valor)
        {
            return BuscarRecursivo(raiz, valor);
        }

        private bool BuscarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                Console.WriteLine($"{valor} no encontrado.");
                return false;
            }

            if (valor == nodo.Valor)
            {
                Console.WriteLine($"{valor} encontrado.");
                return true;
            }

            if (valor < nodo.Valor)
            {
                Console.WriteLine($"Moviendo a la izquierda para buscar {valor}");
                return BuscarRecursivo(nodo.Izquierdo, valor);
            }
            else
            {
                Console.WriteLine($"Moviendo a la derecha para buscar {valor}");
                return BuscarRecursivo(nodo.Derecho, valor);
            }
        }

        // Eliminar un valor del árbol
        public void Eliminar(int valor)
        {
            raiz = EliminarRecursivo(raiz, valor);
        }

        private Nodo EliminarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                Console.WriteLine($"{valor} no encontrado para eliminar.");
                return nodo;
            }

            if (valor < nodo.Valor)
            {
                Console.WriteLine($"Moviendo a la izquierda para eliminar {valor}");
                nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, valor);
            }
            else if (valor > nodo.Valor)
            {
                Console.WriteLine($"Moviendo a la derecha para eliminar {valor}");
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, valor);
            }
            else
            {
                Console.WriteLine($"Eliminando {valor}");
                if (nodo.Izquierdo == null)
                    return nodo.Derecho;
                else if (nodo.Derecho == null)
                    return nodo.Izquierdo;

                nodo.Valor = MinValor(nodo.Derecho);
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, nodo.Valor);
            }

            return nodo;
        }

        private int MinValor(Nodo nodo)
        {
            int minValor = nodo.Valor;
            while (nodo.Izquierdo != null)
            {
                minValor = nodo.Izquierdo.Valor;
                nodo = nodo.Izquierdo;
            }
            return minValor;
        }

        // Imprimir el árbol en orden
        public void ImprimirEnOrden(ListBox listBox)
        {
            listBox.Items.Clear(); // Limpia el ListBox antes de llenarlo
            ImprimirEnOrdenRecursivo(raiz, listBox);
        }

        private void ImprimirEnOrdenRecursivo(Nodo nodo, ListBox listBox)
        {
            if (nodo != null)
            {
                ImprimirEnOrdenRecursivo(nodo.Izquierdo, listBox);
                listBox.Items.Add(nodo.Valor); // Agrega cada valor al ListBox
                ImprimirEnOrdenRecursivo(nodo.Derecho, listBox);
            }
        }
        public void ImprimirComoPiramide(ListBox listBox)
        {
            listBox.Items.Clear(); // Limpia el ListBox antes de llenarlo

            if (raiz == null)
            {
                listBox.Items.Add("Árbol vacío");
                return;
            }

            Queue<Nodo> cola = new Queue<Nodo>();
            cola.Enqueue(raiz);

            while (cola.Count > 0)
            {
                int nivelSize = cola.Count;
                string nivel = "";

                for (int i = 0; i < nivelSize; i++)
                {
                    Nodo actual = cola.Dequeue();
                    nivel += $"{actual.Valor} ";

                    if (actual.Izquierdo != null) cola.Enqueue(actual.Izquierdo);
                    if (actual.Derecho != null) cola.Enqueue(actual.Derecho);
                }

                listBox.Items.Add(nivel.Trim()); // Agrega la fila del nivel
            }
        }
    }
}

