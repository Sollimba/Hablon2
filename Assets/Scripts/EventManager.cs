using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static event UnityAction<int> OnAddPoints;
    public static event UnityAction<Vector2> OnPlayerMove;
    public static event UnityAction OnLevelComplete;
    public static event UnityAction<string> OnItemCollected;

    public static void RaiseAddPoints(int points) => OnAddPoints?.Invoke(points);
    public static void RaisePlayerMove(Vector2 direction) => OnPlayerMove?.Invoke(direction);
    public static void RaiseLevelComplete() => OnLevelComplete?.Invoke();
    public static void RaiseItemCollected(string itemName) => OnItemCollected?.Invoke(itemName);
}
