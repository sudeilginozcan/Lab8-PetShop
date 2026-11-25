class Dog : Animal
{
    public string Breed = "";

    public Dog(string dogName, int dogAge, string dogBreed)
        : base(dogName, dogAge)
    {
        Breed = dogBreed;
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} brings the ball back!");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Woof!");
    }
}