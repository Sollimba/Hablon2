using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int currentScore = 0;
    private bool bonusGiven = false;
    public int coinsCollected = 0;
    public int totalCoinsInLevel = 5;
    public int currentLevel = 1;

    public Text scoreText;
    public Text coinsText;
    public Text levelText;

    private void OnEnable()
    {
        EventManager.OnAddPoints += HandleAddPoints;
        EventManager.OnCoinCollected += HandleCoinCollected;
        EventManager.OnLevelComplete += HandleLevelComplete;
    }

    private void OnDisable()
    {
        EventManager.OnAddPoints -= HandleAddPoints;
        EventManager.OnCoinCollected -= HandleCoinCollected;
        EventManager.OnLevelComplete -= HandleLevelComplete;
    }

    private void HandleAddPoints(int points)
    {
        currentScore += points;
        scoreText.text = "Score: " + currentScore;

        if (currentScore >= 50 && !bonusGiven)
        {
            bonusGiven = true;
            EventManager.RaiseAddPoints(100);
            Debug.Log("Good job!");
        }
    }

    private void HandleCoinCollected()
    {
        coinsCollected++;
        coinsText.text = "Coins: " + coinsCollected;

        if (coinsCollected >= totalCoinsInLevel)
        {
            EventManager.RaiseLevelComplete();
        }
    }

    private void HandleLevelComplete()
    {
        currentLevel++;
        coinsCollected = 0; 
        levelText.text = "Level: " + currentLevel;
        Debug.Log("Transition to new level");
    }
}
