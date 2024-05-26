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
    }

    public void CompleteLevel()
    {
        EventManager.RaiseLevelComplete();
    }
}
