using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    /*
        To calculate score, multiply elapsedTime with ObstacleMoveSpeed and an arbitrary _scoreFactor. Keep checking if player is dead or not throughout.
    */
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] float _scoreFactor;
    void Update()
    {
        if (!GameManager.IsDead)
        {
            _scoreText.text = (GameManager.TimeAlive * GameGlobals.OBSTACLE_MOVE_SPEED * GameGlobals.TimeFactor * _scoreFactor).ToString("0");
        }
    }
}
