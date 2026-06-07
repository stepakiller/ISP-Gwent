using UnityEngine;
[CreateAssetMenu(fileName = "ArcherCard", menuName = "Gwent/Cards/Archer")]
public class ArcherCardSO : UnitCardSO, IArcher
{
    public override void ApplyAction() => ApplyPower();
}