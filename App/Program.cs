Arreglos.Pilas pila = new Arreglos.Pilas(10);
Console.WriteLine(pila.ObtenerDatos());
Console.WriteLine("-------");

pila.Agregar("A");
pila.Agregar("B");
pila.Agregar("C");
pila.Agregar("D");
pila.Agregar("E");
pila.Agregar("F");
Console.WriteLine(pila.ObtenerDatos());
Console.WriteLine("-------");

pila.Eliminar();
Console.WriteLine(pila.ObtenerDatos());
Console.WriteLine("-------");
pila.Eliminar();
Console.WriteLine(pila.ObtenerDatos());
Console.WriteLine("-------");