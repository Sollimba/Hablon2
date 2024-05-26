using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int currentScore = 0;
    private bool bonusGiven = false; // Флаг, чтобы предотвратить бесконечный цикл

    private void OnEnable()
    {
        EventManager.OnAddPoints += HandleAddPoints;
    }

    private void OnDisable()
    {
        EventManager.OnAddPoints -= HandleAddPoints;
    }

    private void HandleAddPoints(int points)
    {
        currentScore += points;

        // Логика для выдачи бонуса
        if (currentScore >= 50 && !bonusGiven)
        {
            bonusGiven = true;
            EventManager.RaiseAddPoints(100); // Выдача бонусных очков
            Debug.Log("Good job!");
        }
    }
}
