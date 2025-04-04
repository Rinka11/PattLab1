namespace PattLab1.Armeowrs;

public abstract class Armor
{
    public string Name { get; protected set; }

    protected Armor(string name)
    {
        Name = name;
    }
}