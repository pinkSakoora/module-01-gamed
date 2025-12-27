using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    /*
        To calculate score, multiply elapsedTime with ObstacleMoveSpeed and an arbitrary _scoreFactor. Keep checking if player is dead or not throughout.
    */
    [SerializeField] TextMeshProUGUI _scoreText;
    private float _elapsedTime = 0;
    [SerializeField] float _scoreFactor = 0.1f;
    [SerializeField] GameManager _gameManager;
    void Update()
    {
        if (!_gameManager.IsDead)
        {
            _elapsedTime += Time.deltaTime;
            _scoreText.text = (_elapsedTime * GameGlobals.OBSTACLE_MOVE_SPEED * _scoreFactor).ToString("0");
        }
    }
}
