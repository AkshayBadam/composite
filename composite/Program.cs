public class Animal
{
    string name;
    public List<Animal> list=new List<Animal>();
    public Animal(string name)  
    {
        this.name = name;
    }
    public void add(Animal a)
    {
        list.Add(a);
    }
    public void display()
    {
        Console.WriteLine(list);
    }
    public static void Main()
    {
        Animal An= new Animal("Living Things");
        Animal Animals = new Animal("Animals");
        An.add(Animals);
        Animal herbivore = new Animal("herbivore");
        Animals.add(herbivore);
        Console.WriteLine(Animals);

    }
}