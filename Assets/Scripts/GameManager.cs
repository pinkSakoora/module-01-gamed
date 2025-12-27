using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
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
