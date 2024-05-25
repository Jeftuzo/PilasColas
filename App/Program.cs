Arreglos.Pilas pila = new Arreglos.Pilas(10);
Arreglos.Colas cola = new Arreglos.Colas(10);

Console.WriteLine(cola.ObtenerDatos());
Console.WriteLine("-------");
cola.Agregar("A");
cola.Agregar("B");
cola.Agregar("C");
cola.Agregar("D");
cola.Agregar("E");
cola.Agregar("F");
Console.WriteLine(cola.ObtenerDatos());
Console.WriteLine("-------");

cola.Eliminar();
Console.WriteLine(cola.ObtenerDatos());
Console.WriteLine("-------");
cola.Eliminar();
Console.WriteLine(cola.ObtenerDatos());
Console.WriteLine("-------");

//Console.WriteLine(pila.ObtenerDatos());
//Console.WriteLine("-------");
//pila.Agregar("A");
//pila.Agregar("B");
//pila.Agregar("C");
//pila.Agregar("D");
//pila.Agregar("E");
//pila.Agregar("F");
//Console.WriteLine(pila.ObtenerDatos());
//Console.WriteLine("-------");

//pila.Eliminar();
//Console.WriteLine(pila.ObtenerDatos());
//Console.WriteLine("-------");
//pila.Eliminar();
//Console.WriteLine(pila.ObtenerDatos());
//Console.WriteLine("-------");