using PattLab1.Meowpons.Catans;
using PattLab1.Meowpons.Sweords;
using PattLab1.Pusheens;

namespace PattLab1;

class Program
{
    static void Main(string[] args)
    {
        var pusheen = new KnightWeowrrior("Barsik", new Purrsword());
        var pusheen2 = new SamuraiMeowshido("Plush", new Nyaunchaku());
        pusheen2.Attack();
        pusheen.Attack();
        pusheen.SetMeowpon(new Claypaw());
        pusheen.Attack();
    }
}
