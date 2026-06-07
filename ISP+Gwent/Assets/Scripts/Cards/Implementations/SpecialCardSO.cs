using UnityEngine;
[CreateAssetMenu(fileName = "SpecialCard", menuName = "Gwent/Cards/Special")]
public class SpecialCardSO : CardSO, IHasSpecialAbility, IExecution
{
    [SerializeField] SpecialAbilityType abilityType;
    public SpecialAbilityType AbilityType => abilityType;
    public void ApplySpecialAbility() => Debug.Log($"{CardName} применяет спец способность");
    public void Execute() => Debug.Log($"{CardName} уничтожает сильнейшие отряды");
    public override void ApplyAction() 
    {
        ApplySpecialAbility();
        if (this is IExecution executionCard) executionCard.Execute();
    }
}