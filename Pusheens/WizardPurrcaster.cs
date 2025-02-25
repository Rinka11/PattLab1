using PattLab1.Meowpons;
using PattLab1.Meowpons.MeowgicWands;

namespace PattLab1.Pusheens;

public class WizardPurrcaster : Pusheen<IMeowgicWand>
{
    public WizardPurrcaster(string name, IMeowgicWand meowpon) : base(name, meowpon)
    {
    }
}