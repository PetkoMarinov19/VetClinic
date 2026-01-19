public interface IAnimal
{
    string Name { get; }
    DateTime Birthday { get; }
    string Breed { get; }
    string MedicalHistory { get; }
    double Weight { get; }
    string Color { get; }
    AnimalStatus Status { get; set; }
}
