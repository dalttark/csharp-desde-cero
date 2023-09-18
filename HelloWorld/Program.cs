namespace HelloWorld
{

    class Program
    {
        static void Main()
        {
            
            DateOnly dateconverted = new DateOnly();
            string nameInput;
            string birthdayInput;
            Console.WriteLine("Hola, bienvenido al calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput=Console.ReadLine();
            Console.WriteLine($"Es un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento dd/mm/aa: ");
            birthdayInput=Console.ReadLine();
            bool isDatevalid = DateOnly.TryParse(birthdayInput,out dateconverted);
            if(isDatevalid==false) Console.WriteLine($"F nac invalid, dato erroneo {birthdayInput}");
            var person = new Person{
                Name=nameInput,
                Birthday=dateconverted,
                Age = DateTime.Now.Year - dateconverted.Year
            };
            Console.WriteLine($"Tu nombre: {person.Name}");
            Console.WriteLine($"Tu fec Nac: {person.Birthday}");
            Console.WriteLine($"Tu edad es {person.Age} años!");





            Console.WriteLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }

}