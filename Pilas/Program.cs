// See https://aka.ms/new-console-template for more information
using Pilas;
using System.Collections;


Persona persona1 = new Persona();

Stack<string> pila1 = new Stack<string>();

Stack pila2 = new Stack();

// Agregar elementos a la pila
pila1.Push("hola");
pila1.Push("mundo1");
pila1.Push("mundo2");

pila2.Push(1);
pila2.Push(20);
pila2.Push(persona1);  //objeto

// Quitar elementos a la pila
pila1.Pop();

// Acceder al elemento superior de la pila
string elementoSuperior = pila1.Peek();

// Saber cuantos elementos tiene la pila
Console.WriteLine("Num elementos: " + pila1.Count);

// Recorrido 
foreach (var item in pila1)
{
    Console.WriteLine(item);
}

