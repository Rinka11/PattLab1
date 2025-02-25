using PattLab1.Meowpons;
using PattLab1.Meowpons.PurrTraps;

namespace PattLab1.Pusheens;

public class ThiefSneakpaws : Pusheen<IPurrTrap>
{
    public ThiefSneakpaws(string name, IPurrTrap meowpon) : base(name, meowpon)
    {
    }
}