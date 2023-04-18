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

Console.WriteLine(pila2.GetType());
Console.WriteLine(pila1.ToArray());



Console.WriteLine("+++++++++++++++++++++++");

var stack = new Stack();
stack.Push("casa");
stack.Push(2.5);
stack.Push(1);

foreach (var item in stack)
{
    Console.WriteLine(item);
}

// Creo una pila nueva con los datos ordenados
var list = stack.Cast<IComparable>().ToList();
list.Sort();
var sortedStack = new Stack(list);

foreach (var item in sortedStack)
{
    Console.WriteLine(item);
}





