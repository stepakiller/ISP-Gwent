using UnityEngine;
public abstract class CardSO : ScriptableObject
{
    public string CardName;
    public Sprite Icon;
    [TextArea] public string Description;
    public abstract void ApplyAction();
}
