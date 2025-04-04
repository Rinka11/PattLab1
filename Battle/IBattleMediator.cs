using PattLab1.Armeowrs;
using PattLab1.Meowpons;
using PattLab1.Pusheens;

namespace PattLab1.Battle;

public interface IBattleMediator
{
    void Attack(IMeowpon meowpon, Armor armor);
}