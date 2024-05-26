using UnityEngine;

public class LevelController : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnLevelComplete += HandleLevelComplete;
    }

    private void OnDisable()
    {
        EventManager.OnLevelComplete -= HandleLevelComplete;
    }

    private void HandleLevelComplete()
    {
        Debug.Log("Level Completed!");
        Debug.Log("Transition to new level");
    }

    public void CompleteLevel()
    {
        EventManager.RaiseLevelComplete();
    }
}
