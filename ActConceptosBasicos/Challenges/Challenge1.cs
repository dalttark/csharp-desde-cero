namespace csharp.basic{

    //"1. Solicita al usuario un número y eleva este número al cuadrado solo si es positivo."
    public class Challenge1{
        public void Run(){
            Console.WriteLine("Ingresa un numero: ");
            int num = int.Parse(Console.ReadLine());
            if(num>0){
                double resultado = Math.Pow(num, 2);
                Console.WriteLine("El cuadrado del numero ingresado es: " + resultado);
            }
            else if (num<0) Console.WriteLine("Numero ingresado es negativo");
            else Console.WriteLine("Numero ingresado es cero");
        }
    }
    
    //2.Solicita al usuario dos números. Si el primero es mayor, devuelva su doble, de lo contrario devuelva el triple del segundo
    public class Challenge2{
        public void Run(){
            Console.WriteLine("Ingresa el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            if(num1>num2){
                double resultado = num1*2;
                Console.WriteLine("El doble del numero 1 es: " + resultado);
            }
            else if (num1<num2) Console.WriteLine($"El triple del numero 2 es: {num2*3}");
            else Console.WriteLine("Numeros ingresados son iguales");
        }
    }

  //3.: Pide al usuario un número. Si es positivo, devuelve su raíz cuadrada, de lo contrario, devuelve su cuadrado. 
    public class Challenge3{
        public void Run(){
            Console.WriteLine("Ingresa un numero: ");
            int num = int.Parse(Console.ReadLine());
            if(num>0){
                double resultado = Math.Sqrt(num);
                Console.WriteLine("La raiz cuadrada del numero ingresado es: " + resultado);
            }
            else if (num<0) Console.WriteLine($"El cuadrado del numero ingresado es: {Math.Pow(num,2)}");
            else Console.WriteLine("Numero ingresado es cero");
        }
    }

    //4. Pide al usuario un número. Si es positivo, devuelve su raíz cuadrada, de lo contrario, devuelve su cuadrado. 
    public class Challenge4{
        public void Run(){
            Console.Write("Por favor, ingresa el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());
            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine("El perímetro del círculo con radio " + radio + " es " + perimetro);
        }
    }

    //5. Solicita al usuario un número entre 1 y 7 y muestra el día de la semana correspondiente, pero solo considerando los días laborables. 
    public class Challenge5{
        public void Run(){
        Console.Write("Por favor, ingresa un número entre 1 y 7: ");
        int num = int.Parse(Console.ReadLine());
        string diaSemana = "";

        switch (num){
            case 1:
                diaSemana = "Lunes";
                break;
            case 2:
                diaSemana = "Martes";
                break;
            case 3:
                diaSemana = "Miércoles";
                break;
            case 4:
                diaSemana = "Jueves";
                break;
            case 5:
                diaSemana = "Viernes";
                break;
            default:
                Console.WriteLine("El número ingresado no corresponde a un día laborable.");
                return;
        }

        Console.WriteLine("El día de la semana correspondiente al número " + num + " es " + diaSemana);
        }
    }

    //6.Solicita al usuario su salario anual y, si este excede los 12000, muestra el impuesto a pagar que es el 15% del excedente.
    public class Challenge6{
        public void Run(){
            Console.Write("Por favor, ingresa su salario anual: ");
            double salario = double.Parse(Console.ReadLine());
            double excedente = 12000;
            double impuesto;
            if (salario >= excedente){
                impuesto = (salario-excedente) * 0.15;
                Console.WriteLine($"El impuesto a pagar es: {impuesto}");
            }
            else{
                Console.WriteLine("No excediste el valor, por ende no tienes que pagar impuestos");
            }
        }
    }
    //7.Solicita dos números y muestra el residuo de la división del primero entre el segundo.
    public class Challenge7{
        public void Run(){
            Console.WriteLine("Ingresa el primer numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());
            double residuo = num1 + num2;
            Console.WriteLine($"El residuo de la división de {num1} + entre  + {num2} es {residuo}");
        }
    }
}