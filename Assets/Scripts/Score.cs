using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    /*
        To calculate score, multiply elapsedTime with ObstacleMoveSpeed and an arbitrary _scoreFactor. Keep checking if player is dead or not throughout.
    */
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] float _scoreFactor;
    [SerializeField] GameManager _gameManager;
    void Update()
    {
        if (!_gameManager.IsDead)
        {
            _scoreText.text = (Time.timeSinceLevelLoad * GameGlobals.OBSTACLE_MOVE_SPEED * GameGlobals.TimeFactor * _scoreFactor).ToString("0");
        }
    }
}
