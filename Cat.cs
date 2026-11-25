class Cat : Animal
{
    public Cat(string catName, int catAge)
        : base(catName, catAge)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Meow!");
    }
}