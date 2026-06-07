using UnityEngine;
[CreateAssetMenu(fileName = "SpyMeleeCard", menuName = "Gwent/Cards/SpyMelee")]
public class SpyMeleeCardSO : UnitCardSO, IMeleeFighter, ISpy, IHasSpecialAbility
{
    public SpecialAbilityType AbilityType => SpecialAbilityType.Spy;
    public void ApplySpecialAbility() => ApplySpyEffect();
    public void ApplySpyEffect() => Debug.Log($"{CardName} переходит на сторону врага и берет 2 карты");
    public override void ApplyAction() 
    {
        ApplyPower();
        ApplySpecialAbility();
    }
}
