namespace csharp.basic{
  class Program{
    static void Main(string[] args){
      Console.WriteLine("Ingrese su nombre: ");
      string nombre = Console.ReadLine();
      Console.WriteLine($"Hola, {nombre}! Elige un ejercicio del menú: ");
      Menu.MostrarMenu();
      while (true){
        
        string entrada = Console.ReadLine().ToLower();
        if (entrada == "q" || entrada == "exit"){
          break;
        }

        if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <=15){
            switch (eleccion){
                case 1:
                    var Challenge1 = new Challenge1();
                    Challenge1.Run();
                    break;
                case 2:
                    var Challenge2 = new Challenge2();
                    Challenge2.Run();
                    break;
                case 3:
                    var Challenge3 = new Challenge3();
                    Challenge3.Run();
                    break;
                case 4:
                    var Challenge4 = new Challenge4();
                    Challenge4.Run();
                    break;
                case 5:
                    var Challenge5 = new Challenge5();
                    Challenge5.Run();
                    break;
                case 6:
                    var Challenge6 = new Challenge6();
                    Challenge.Run();
                    break;
                case 7:
                    var Challenge7 = new Challenge7();
                    Challenge.Run();
                    break;
                
                default:
                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.MostrarMenu();
                    break;
            }
            Console.WriteLine("\nVuelve a ingresar un numero de acuerdo a los ejercicios del menú: ");

        }
        else{
            Console.WriteLine("Opción no válida. Por favor, Ingrese un numero entre 1 y 15, o 'q' o 'exit' para salir");
        }
        
      }
      Console.WriteLine("Hasta Luego");
    }
  }

}