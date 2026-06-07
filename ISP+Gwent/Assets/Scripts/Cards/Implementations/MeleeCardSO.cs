using UnityEngine;
[CreateAssetMenu(fileName = "MeleeCard", menuName = "Gwent/Cards/Melee")]
public class MeleeCardSO : UnitCardSO, IMeleeFighter
{
    public override void ApplyAction() => ApplyPower();
}
