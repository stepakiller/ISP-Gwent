using UnityEngine;
using System.Collections.Generic;
using System.Text;
public class Bootstrap : MonoBehaviour
{
    [SerializeField] Transform meleeRow;
    [SerializeField] Transform archerRow;
    [SerializeField] Transform siegeRow;
    [SerializeField] CardView cardViewPrefab;
    [SerializeField] Transform tableContainer;
    [SerializeField] List<CardSO> deckData;
    CardPool _cardPool;
    void Start()
    {
        _cardPool = new CardPool(cardViewPrefab, tableContainer, deckData.Count);
        foreach (var cardData in deckData)
        {
            var cardInstance = _cardPool.Get();
            cardInstance.Initialize(cardData);
            Transform targetParent = tableContainer;
            if (cardData is IMeleeFighter) targetParent = meleeRow;
            else if (cardData is IArcher) targetParent = archerRow;
            else if (cardData is ISiegeWeapon) targetParent = siegeRow;
            cardInstance.transform.SetParent(targetParent, false);
            LogCardInfo(cardData);
        }
    }
    void LogCardInfo(CardSO card)
    {
        string placement = "Нет";
        if (card is IMeleeFighter) placement = "Ближний бой";
        else if (card is IArcher) placement = "Дальний бой";
        else if (card is ISiegeWeapon) placement = "Осадное оржие";
        StringBuilder specialText = new StringBuilder();
        if (card is IHasSpecialAbility) specialText.Append("Есть ");
        if (card is ISpy) specialText.Append("Шпион ");
        if (card is IExecution) specialText.Append("Казнь ");
        if (card is IWeatherCard) specialText.Append("Погода ");
        if (card is ILeaderCard) specialText.Append("Ульта ");
        string special = specialText.Length > 0 ? specialText.ToString().Trim() : "Нет";
        string power = card is IHasPower hp ? hp.PowerPoints.ToString() : "Нет";
        Debug.Log($"Создана карта {card.CardName}; тип размещения: {placement}; специальная способность: {special}; очки силы: {power}");
    }
}