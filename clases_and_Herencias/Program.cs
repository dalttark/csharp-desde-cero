// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/******* _ejercicio de Clase rectangulo_ *****
var rect=new Rectangulo();
rect.Base=20;
rect.Altura=40;
Console.WriteLine($"El área es: {rect.Area()}");
Console.WriteLine($"El Perimetro es: {rect.Perimetro()}");

class Rectangulo{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area(){
        return Base * Altura;
    }
     public double Perimetro(){
        return 2*Base + 2*Altura;
    }
}
*/

var cuadr=new Cuadrado();
cuadr.Base=20;
cuadr.Altura=40;
Console.WriteLine($"El área es: {cuadr.Area()}");
Console.WriteLine($"El Lado es: {cuadr.Perimetro()}");
Console.WriteLine($"El Lado es: {cuadr.Lado}");

class Rectangulo{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area(){
        return Base * Altura;
    }
     public double Perimetro(){
        return 2*Base + 2*Altura;
    }
}

class Cuadrado : Rectangulo{
    public double Lado{
        set {Base = value; Altura = value;}
        get {return Base;}
    }
}

