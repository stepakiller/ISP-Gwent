using UnityEngine;
[CreateAssetMenu(fileName = "SiegeCard", menuName = "Gwent/Cards/Siege")]
public class SiegeCardSO : UnitCardSO, ISiegeWeapon
{
    public override void ApplyAction() => ApplyPower();
}
