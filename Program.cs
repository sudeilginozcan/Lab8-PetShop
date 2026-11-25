Console.OutputEncoding = System.Text.Encoding.UTF8;

Animal[] animals =
{
    new Dog("Karabaş", 3, "Kangal"),
    new Cat("Tekir", 2)
};

foreach (Animal a in animals)
{
    a.MakeSound();
}