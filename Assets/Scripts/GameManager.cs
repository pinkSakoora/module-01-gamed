using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] ObstacleSpawner _obstacleSpawner;
    [SerializeField] GameObject _deathScreen;
    public static bool IsDead {get; private set;}
    public static float TimeAlive {get; private set;}

    void Start()
    {
        TimeAlive = 0;
        IsDead = false;
    } 

    void Update()
    {
        if (!IsDead) 
        {
            TimeAlive += Time.deltaTime;
        }
    }
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

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
