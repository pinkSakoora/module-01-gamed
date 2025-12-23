using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    /*
        To calculate score, multiply elapsedTime with ObstacleMoveSpeed and an arbitrary _scoreFactor. Keep checking if player is dead or not throughout.
    */
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] ObstacleSpawner _obstacleSpawner;
    private float _elapsedTime = 0;
    [SerializeField] float _scoreFactor = 0.1f;
    [SerializeField] GameManager _gameManager;
    void Update()
    {
        if (!_gameManager.IsDead)
        {
            _elapsedTime += Time.deltaTime;
            _scoreText.text = (_elapsedTime * _obstacleSpawner.ObstacleMoveSpeed * _scoreFactor).ToString("0");
        }
    }
}
