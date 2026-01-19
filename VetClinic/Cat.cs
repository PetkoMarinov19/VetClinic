public class Cat : IAnimal
{
    public Cat(string name, DateTime birthday, string breed,
        string medicalHistory, double weight, string color, string favoriteToy)
    {
        Name = name;
        Birthday = birthday;
        Breed = breed;
        MedicalHistory = medicalHistory;
        Weight = weight;
        Color = color;
        FavoriteToy = favoriteToy;
        Status = AnimalStatus.NotAdopted;
    }

    public string Name { get; }
    public DateTime Birthday { get; }
    public string Breed { get; }
    public string MedicalHistory { get; }
    public double Weight { get; }
    public string Color { get; }
    public string FavoriteToy { get; }
    public AnimalStatus Status { get; set; }
}
