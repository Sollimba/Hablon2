using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int currentScore = 0;
    private bool bonusGiven = false; // ����, ����� ������������� ����������� ����

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

        // ������ ��� ������ ������
        if (currentScore >= 50 && !bonusGiven)
        {
            bonusGiven = true;
            EventManager.RaiseAddPoints(100); // ������ �������� �����
            Debug.Log("Good job!");
        }
    }
}
