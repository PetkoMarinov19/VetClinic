public class PetManager
{
    private readonly List<IAnimal> pets = new();

    public void AddPet(IAnimal pet)
    {
        pets.Add(pet);
    }

    public void ListPets()
    {
        if (!pets.Any())
        {
            Console.WriteLine("No pets available.");
            return;
        }

        for (int i = 0; i < pets.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {pets[i].Name} ({pets[i].GetType().Name})");
        }
    }

    public IAnimal GetPetByIndex(int index)
    {
        if (index < 0 || index >= pets.Count)
            return null;

        return pets[index];
    }
}
