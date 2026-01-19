public class Menu
{
    private readonly PetManager petManager;

    public Menu(PetManager petManager)
    {
        this.petManager = petManager;
    }

    public void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Vet Clinic ===");
            Console.WriteLine("1. List pets");
            Console.WriteLine("2. Add new pet");
            Console.WriteLine("3. View pet details");
            Console.WriteLine("4. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": ListPets(); break;
                case "2": AddPet(); break;
                case "3": ViewPetDetails(); break;
                case "4": return;
                default: Console.WriteLine("Invalid choice."); break;
            }

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }

    private void ListPets()
    {
        petManager.ListPets();
    }

    private void AddPet()
    {
        Console.Write("Cat or Dog: ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Breed: ");
        string breed = Console.ReadLine();

        Console.Write("Color: ");
        string color = Console.ReadLine();

        Console.Write("Medical history: ");
        string history = Console.ReadLine();

        Console.Write("Weight: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Birthday (yyyy-mm-dd): ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        if (type == "cat")
        {
            Console.Write("Favorite toy: ");
            string toy = Console.ReadLine();

            petManager.AddPet(new Cat(name, birthday, breed, history, weight, color, toy));
        }
        else
        {
            petManager.AddPet(new Dog(name, birthday, breed, history, weight, color));
        }

        Console.WriteLine("Pet added successfully!");
    }

    private void ViewPetDetails()
    {
        petManager.ListPets();
        Console.Write("Select pet number: ");

        int index = int.Parse(Console.ReadLine()) - 1;
        IAnimal pet = petManager.GetPetByIndex(index);

        if (pet == null)
        {
            Console.WriteLine("Invalid pet.");
            return;
        }

        Console.WriteLine($"\nName: {pet.Name}");
        Console.WriteLine($"Type: {pet.GetType().Name}");
        Console.WriteLine($"Birthday: {pet.Birthday:d}");
        Console.WriteLine($"Breed: {pet.Breed}");
        Console.WriteLine($"Color: {pet.Color}");
        Console.WriteLine($"Weight: {pet.Weight}");
        Console.WriteLine($"Medical History: {pet.MedicalHistory}");
        Console.WriteLine($"Status: {pet.Status}");

        if (pet is Cat cat)
        {
            Console.WriteLine($"Favorite Toy: {cat.FavoriteToy}");
        }

        if (pet.Status == AnimalStatus.NotAdopted)
        {
            Console.Write("Adopt this pet? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                pet.Status = AnimalStatus.Adopted;
                Console.WriteLine("Pet adopted!");
            }
        }
    }
}
