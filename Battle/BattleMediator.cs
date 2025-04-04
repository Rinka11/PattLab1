using PattLab1.Armeowrs;
using PattLab1.Meowpons;
using PattLab1.Meowpons.Catans;
using PattLab1.Meowpons.MeowgicWands;
using PattLab1.Meowpons.PurrTraps;
using PattLab1.Meowpons.Sweords;

namespace PattLab1.Battle;

public class BattleMediator : IBattleMediator
{
    public void Attack(IMeowpon meowpon, Armor armor)
    {
        meowpon.Use();
        
        switch (meowpon)
        {
            case ICatana:
                switch (armor)
                {
                    case MudArmor:
                        Console.WriteLine("The katana is sliding!");
                        break;
                    case WoolArmor:
                        Console.WriteLine("Katana cuts wool!");
                        break;
                }
                break;
            case IMeowgicWand:
                switch (armor)
                {
                    case MudArmor:
                        Console.WriteLine("The dirt is flying!");
                        break;
                    case WoolArmor:
                        Console.WriteLine("Wool is electrified!");
                        break;
                }
                break;
            case IPurrTrap:
                switch (armor)
                {
                    case MudArmor:
                        Console.WriteLine("The dirt is playing against him!");
                        break;
                    case WoolArmor:
                        Console.WriteLine("Caught on the wool!");
                        break;
                }
                break;
            case ISweord:
                switch (armor)
                {
                    case MudArmor:
                        Console.WriteLine("The sword pierces mud armor!");
                        break;
                    case WoolArmor:
                        Console.WriteLine("A sword can easily handle wool!");
                        break;
                }
                break;
        }
    }
}