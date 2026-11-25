class Animal
{
    public string Name = "";
    public int Age;

    public Animal(string animalName, int animalAge)
    {
        Name = animalName;
        Age = animalAge;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound");
    }
}