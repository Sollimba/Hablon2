using UnityEngine.Events;

public static class EventManager
{
    public static event UnityAction<int> OnAddPoints;
    public static event UnityAction OnCoinCollected;
    public static event UnityAction OnLevelComplete;

    public static void RaiseAddPoints(int points) => OnAddPoints?.Invoke(points);
    public static void RaiseCoinCollected() => OnCoinCollected?.Invoke();
    public static void RaiseLevelComplete() => OnLevelComplete?.Invoke();
}
