using System;
/*Crear una clase llamada Producto, en el fichero "producto.cs". Esta clase deberá tener los atributos "nombre" y "descripcion", de
 tipo string. También deberá tener un método "agretarNombre", de tipo void y con un parámetro string, que permita cambiar
  el valor del nombre. Finalmente, también tendrá un método "productoDisponible", que escribirá 
  en pantalla "Producto, " seguido de su nombre y la descripción del producto. Crear también una clase llamada verProducto.
 Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo Producto, les asignará un nombre y les pedirá que
  lo muestre en pantalla.*/
public class Producto
{
    string nombre;
    string descripcion;
    void agretarNombre(string nomb)
    {
        Producto nuevoNombre = new Producto();
        nuevoNombre.nombre= nomb;
    }
    string productoDisponible()
    {
        Console.WriteLine("Producto", nombre ," ", descripcion);
    }


}
public class verProducto
{
    static void Main()
    {
        Producto obj1= new Producto();
        Producto obj2= new Producto();
        obj1.agretarNombre(Console.ReadLine());
        obj1.productoDisponible(Console.ReadLine());
        obj2.agretarNombre(Console.ReadLine());
        obj2.productoDisponible(Console.ReadLine());
        Console.WriteLine(obj2.productoDisponible);
        Console.WriteLine(obj1.productoDisponible);
    }
}