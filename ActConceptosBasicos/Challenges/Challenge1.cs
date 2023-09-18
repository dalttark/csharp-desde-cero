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
            double residuo = num1 % num2;
            Console.WriteLine($"El residuo de la división de {num1} entre {num2} es {residuo}");
        }
    }

    //8.Calcula y muestra la suma de los números pares entre 1 y 50.
    public class Challenge8{
        public void Run(){
            int suma = 0;
            for (int numero = 1; numero <= 50; numero++){
                if (numero % 2 == 0){
                suma += numero;
                }
            }
            Console.WriteLine("La suma de los números pares entre 1 y 50 es: " + suma);
        }
    }

    //9. Solicita al usuario los valores para dos fracciones y muestra la diferencia entre esas fracciones."
    public class Challenge9{
        public void Run(){
            Console.Write("Ingresa el numerador de la primera fracción: ");
            int numerador1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el denominador de la primera fracción: ");
            int denominador1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el numerador de la segunda fracción: ");
            int numerador2 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el denominador de la segunda fracción: ");
            int denominador2 = int.Parse(Console.ReadLine());

            if (denominador1 == 0 || denominador2 == 0){
                Console.WriteLine("Error: Los denominadores no pueden ser cero.");
            }
            else{
                int resultadoNumerador = (numerador1 * denominador2) - (numerador2 * denominador1);
                int resultadoDenominador = denominador1 * denominador2;
                Console.WriteLine("La diferencia entre las fracciones es: " + resultadoNumerador + "/" + resultadoDenominador);
            }
        }
    }

    // 10. Pide una palabra al usuario y muestra la longitud de esa palabra.
    public class Challenge10{
        public void Run(){
            Console.Write("Por favor, ingresa una palabra: ");
            string palabra = Console.ReadLine();
            int longitud = palabra.Length;
            Console.WriteLine("La longitud de la palabra '" + palabra + "' es " + longitud + " caracteres.");
        }
    }

    //11. Pide al usuario cuatro números y muestra el promedio
    public class Challenge11{
        public void Run(){
            Console.WriteLine("Por favor, ingresa el primer número: ");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingresa el segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingresa el tercer número: ");
            double numero3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingresa el cuarto número: ");
            double numero4 = double.Parse(Console.ReadLine());

            double suma = numero + numero2 + numero3 + numero4;

            double cantidadNumeros = 4;
            double promedio = suma / cantidadNumeros;
            Console.WriteLine("El promedio de los cuatro números ingresados es: " + promedio);
        }
    }

    // 12. Pide al usuario cinco números y muestra el más pequeño.
    public class Challenge12{
        public void Run(){
            Console.WriteLine("Por favor, ingresa cinco números: ");
            double numeroMinimo = double.MaxValue; 
            for (int i = 1; i <= 5; i++){
                Console.Write("Número " + i + ": ");
                double numero = double.Parse(Console.ReadLine());
                if (numero < numeroMinimo){
                    numeroMinimo = numero; 
                }
            }
            Console.WriteLine("El número más pequeño ingresado es: " + numeroMinimo);
        }
    }
    // "13. Pide una palabra al usuario y devuelve el número de vocales en esa palabra"
    public class Challenge13{
        public void Run(){
            Console.Write("Por favor, ingresa una palabra: ");
            string palabra = Console.ReadLine();

            int contadorVocales = 0;

            for (int i = 0; i < palabra.Length; i++){
                char letra = char.ToLower(palabra[i]); // Convertir a minúscula para comparación

                if ("aeiou".Contains(letra)){
                    contadorVocales++;
                }
            }
            Console.WriteLine("El número de vocales en la palabra '" + palabra + "' es: " + contadorVocales);
        }
    }

    //"14.  Pide un número al usuario y devuelve el factorial de ese número."
    public class Challenge14{
        public void Run(){
            Console.Write("Por favor, ingresa un número positivo: ");
            int numero = int.Parse(Console.ReadLine());

            long factorial = 1; // Inicializamos el factorial en 1

            for (int i = 1; i <= numero; i++){
            factorial *= i;
            }

            Console.WriteLine("El factorial de " + numero + " es " + factorial);
        }
    }

    // 15. : Pide un número al usuario y verifica si está en el rango de 10 a 20 (ambos incluidos). "
    public class Challenge15{
        public void Run(){
            Console.Write("Dame un numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero<=20 && numero>=10){
                Console.WriteLine("El numero ingresado se encunetra en el rango de 10 y 20");
            }
            else{
                System.Console.WriteLine("El numero no se encuentra en el rango de 10 y 20");
            }
        }
    }   
}