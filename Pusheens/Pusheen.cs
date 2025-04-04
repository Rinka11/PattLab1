using PattLab1.Armeowrs;
using PattLab1.Meowpons;

namespace PattLab1.Pusheens;

public abstract class Pusheen<TMeowpon> where TMeowpon : IMeowpon
{
    public string Name { get; protected set; }
    public Armor Armor { get; protected set; }
    public IMeowpon Meowpon { get; protected set; }

    public Pusheen(string name, IMeowpon meowpon)
    {
        Name = name;
        Meowpon = meowpon;
    }

    public void Attack()
    {
        Console.WriteLine($"{Name} is attacking by The {Meowpon.GetType().Name}!");
        Meowpon.Use();
    }

    public void SetMeowpon(TMeowpon meowpon)
    {
        Console.WriteLine($"{Name} is setting the meowpon to {meowpon.GetType().Name}");
        Meowpon = meowpon;
    }
    
    public void SetArmor(Armor armor)
    {
        Console.WriteLine($"{Name} is setting the armor to {armor.GetType().Name}");
        Armor = armor;
    }
}