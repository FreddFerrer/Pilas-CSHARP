using System.Collections;

namespace PilaTest
{
    public class UnitTest1
    {
        [Fact]
        public void PruebaAgregarElementoAUnaPilaVacia()
        {
            var pila = new Stack<int>();

            // Agrega un elemento a la pila
            pila.Push(42);       
            pila.Push(33);       
            pila.Push(22);       
            pila.Push(11);       

            // Asegúrate de que la pila tenga un elemento
            Assert.Equal(4, pila.Count);
            Assert.Equal(11, pila.Peek());
        }

        [Fact]
        public void PruebaPosicionDeUnElementoEnLaPila()
        {
            // Crea una pila con algunos elementos
            var pila = new Stack();
            pila.Push("elemento1");
            pila.Push("elemento2");
            pila.Push("elemento3");

            // Encuentra la posición del elemento en la pila
            var elementos = pila.ToArray();
            int posicion = 0;
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] == "elemento2")
                {
                    posicion = i;
                    break;
                }
            }

            // Asegúrate de que la posición sea correcta
            Assert.Equal(1, posicion);
        }

        [Fact]
        public void ContieneUnElemento()
        {
            // Crea una pila con algunos elementos
            var pila = new Stack<string>();
            pila.Push("elemento1");
            pila.Push("elemento2");
            pila.Push("elemento3");

            // Encuentra la posición del elemento en la pila
            Assert.Contains("elemento1", pila);
        }


    }
}