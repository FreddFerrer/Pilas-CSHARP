using System.Collections;

namespace PilaTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAgregarElementoAUnaPilaVacia()
        {
            Stack<int> pila = new Stack<int>();

            // Agrega un elemento a la pila
            pila.Push(42);       
            pila.Push(33);       
            pila.Push(22);       
            pila.Push(11);       

            // Asegurarse de que la pila tenga un elemento
            Assert.Equal(4, pila.Count);
        }

        [Fact]
        public void TestPilaVacia()
        {
            // Creo una pila de enteros
            Stack<int> stack = new Stack<int>();

            // Agrego elementos a la pila
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
         
            // Recorro la pila
            while (stack.Count > 0)
            {
                stack.Pop();
            }

            Assert.Equal(0, stack.Count);
        }

        [Fact]
        public void TestPosicionDeUnElementoEnLaPila()
        {
            // Creo una pila sin definir el tipo
            Stack<string> pila = new Stack<string>();
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

            // Posición correcta?
            Assert.Equal(1, posicion);
        }

        [Fact]
        public void TestContieneUnElemento()
        {
            // Creo una pila con algunos elementos (string)
            Stack<string> pila = new Stack<string>();
            pila.Push("elemento1");
            pila.Push("elemento2");
            pila.Push("elemento3");

            // Comprueba la existencia del elemento en la pila
            Assert.Contains("elemento1", pila);
        }

        [Fact]
        public void TestStackPeek()
        {
            // Creo una pila sin definir el tipo que solo reciba 3 elementos
            var stack = new Stack();
            stack.Push("hola");
            stack.Push(2);
            stack.Push(true);

            var elementoSuperior = stack.Peek();

            // Compruebo que el elemento superior sea true
            Assert.Equal(true, elementoSuperior);

        }
    }
}