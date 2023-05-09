namespace GenericApproach 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal
            {
                Name = "Cow",
                Age = 3,
                Type = AnimalType.Harvivore,
                Sex = Gender.Female
            };

            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericBehavior(cow));
            
            Animal bear = new Animal 
            { 
                Name = "Grizzly", 
                Age = 4, 
                Type = AnimalType.Omnivore, 
                Sex = Gender.Male 
            };
            TypeSpecificAnimal<Animal> obj2 = new TypeSpecificAnimal<Animal>();
            Console.WriteLine(obj2.GetTypeSpecicBehavior(bear));
            
            Console.ReadLine();

        }
    }
}