﻿var circ = new Circulo();

circ.Radio = 20;
var result_area = circ.Area();
var result_area = circ.Perimetro();

Console.WriteLine($"El area es: {result_area} y el perimetro es: {result_perim} el nuevo radio es: {circ.Add10()}");

int prev = 0, next = 1, sum;
for (int i = 0; i<10; i++){
    Console.WriteLine(prev);
    sum=prev + next;
    prev = next;
    next = sum;
}

/*
abstract class Figura {
    public abstract double Area();
    public abstract double Perimetro();
}
*/

interface IExtraCalculations{
    public double Add10();
}
interface IFigura
{
    public double Area();
    public double Perimetro();
}

class Circulo : IFigura, IExtraCalculations{
    public double Radio{get; set;}

    public double Area() => Math.PI * Radio * Radio;

    public double Perimetro() => 2 * Math.PI * Radio;

    public double Add10(){
        return Radio + 10;
    }

}