using System.Collections;
using System.Diagnostics;

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

            // Comprueba que la pila tenga un elemento
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

            // Comprueba que la pila este vacia
            Assert.Equal(0, stack.Count);
        }

        [Fact]
        public void TestContieneUnElementoEspecifico()
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
        public void TestPosicionDeUnElementoEnLaPila()
        {
            // Creo una pila que recibe strings
            Stack<string> pila = new Stack<string>();
            pila.Push("elemento1");
            pila.Push("elemento2");
            pila.Push("elemento3");

            var elementos = pila.ToArray();

            int posicion = 0;
            
            // Encuentra la posición del elemento en la pila
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
        public void TestPeek()
        {
            // Creo una pila sin definir el tipo
            var stack = new Stack();
            stack.Push("hola");
            stack.Push(2);
            stack.Push(true);

            var elementoSuperior = stack.Peek();

            // Compruebo que el elemento superior sea true
            Assert.Equal(true, elementoSuperior);

        }

        [Fact]
        public void TestStackPerformance()
        {
            // Creo una pila de enteros
            Stack<int> stack = new Stack<int>();

            // Temporizador
            var stopwatch = new Stopwatch();
            int numElementos = 100000000;

            // Inicio temp.
            stopwatch.Start();

            // Apilar
            for (int i = 0; i < numElementos; i++)
            {
                stack.Push(i);
            }

            // Desapilar
            for (int i = 0; i < numElementos; i++)
            {
                stack.Pop();
            }
            stopwatch.Stop();

            // Compruebo si el tiempo transcurrido es inferior a 1 segundo
            Assert.True(stopwatch.ElapsedMilliseconds < 1000);
        }
    }
}