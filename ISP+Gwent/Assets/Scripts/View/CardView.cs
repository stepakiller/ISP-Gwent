using UnityEngine;

public class CardView : MonoBehaviour
{
    public CardSO Data { get; private set; }
    [SerializeField] SpriteRenderer _spriteRenderer; 

    public void Initialize(CardSO data)
    {
        Data = data;
        if (_spriteRenderer != null && data.Icon != null) _spriteRenderer.sprite = data.Icon;
    }
}
