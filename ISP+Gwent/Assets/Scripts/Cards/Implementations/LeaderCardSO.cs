using UnityEngine;
[CreateAssetMenu(fileName = "LeaderCard", menuName = "Gwent/Cards/Leader")]
public class LeaderCardSO : CardSO, ILeaderCard
{
    public void ApplyUltimate() => Debug.Log($"{CardName} применяет ульту лидера");
    public override void ApplyAction() => ApplyUltimate();
}