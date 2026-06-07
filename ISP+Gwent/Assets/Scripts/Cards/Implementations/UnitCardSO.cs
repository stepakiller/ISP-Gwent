using UnityEngine;
public abstract class UnitCardSO : CardSO, IHasPower
{
    [SerializeField] protected int power;
    public int PowerPoints => power;
    public void ApplyPower() => Debug.Log($"{CardName} выходит на поле с силой {power}.");
}
