class Program
{
    static void Main()
    {
        var petManager = new PetManager();
        var menu = new Menu(petManager);

        menu.Show();
    }
}