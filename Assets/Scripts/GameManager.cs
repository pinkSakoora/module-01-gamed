using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] ObstacleSpawner _obstacleSpawner;
    [SerializeField] GameObject _deathScreen;
    public bool IsDead;
    public void OnDeath()
    {
        IsDead = true;
        _obstacleSpawner.enabled = false;       // Disable this component to stop further spawning
        var spawnedObstacleList = FindObjectsByType<ObstacleMover>(FindObjectsSortMode.None);   // Make a list of all objects containing ObstacleMover
        for (int i = 0; i < spawnedObstacleList.Length; i++)                                    // component (all obstacles) and disable all of them
        {
            spawnedObstacleList[i].enabled = false;
        }
        _deathScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        _deathScreen.SetActive(false);
    }
}
