public class vehiculo
{
    string marca;
    string modelo;
    string color;
    int año;
    string estado= "apagado";
    void estad()
    {   
        vehiculo y = new vehiculo();
        Console.WriteLine("Ingrese 1 para encender, cualquier otra tecla para apagar");
        string estado= Console.ReadLine();
        if(estado == "1")
        {
            y.estado= "Encendido";
        }else{
            y.estado= "apagado";
        }


    }
    public void Main()
    {
        vehiculo ford= new vehiculo();
        ford.marca="ford";
        ford.modelo="turismo";
        ford.color="verde";
        ford.año= 2006;
        Console.WriteLine("marca "+ ford.marca);
		Console.WriteLine("modelo "+ ford.modelo);
		Console.WriteLine("color "+ ford.color);
		Console.WriteLine("Color "+ ford.año);
		Console.WriteLine("Estado "+ ford.estado);
    }
}