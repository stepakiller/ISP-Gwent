using UnityEngine;
[CreateAssetMenu(fileName = "WeatherCard", menuName = "Gwent/Cards/Weather")]
public class WeatherCardSO : CardSO, IWeatherCard
{
    public void ApplyWeatherEffect() => Debug.Log($"{CardName} сгущает мглу");
    public override void ApplyAction() => ApplyWeatherEffect();
}
