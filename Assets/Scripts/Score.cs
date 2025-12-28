using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    /*
        To calculate score, multiply elapsedTime with ObstacleMoveSpeed and an arbitrary _scoreFactor. Keep checking if player is dead or not throughout.
    */
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] TextMeshProUGUI _highscoreText;
    [SerializeField] float _scoreFactor;
    private int _score;

    void Start()
    {
        _score = 0;
        if (!PlayerPrefs.HasKey("SavedHighscore"))
        {
            _highscoreText.enabled = false;
        }
    }

    void Update()
    {
        if (!GameManager.IsDead)
        {
            _score = (int)(GameManager.TimeAlive * GameGlobals.OBSTACLE_MOVE_SPEED * GameGlobals.TimeFactor * _scoreFactor);
            _scoreText.text = _score.ToString();
        }
        else if (!_highscoreText.enabled)
        {
            _highscoreText.enabled = true;
        }
        HighscoreCheck();
    }

    void HighscoreCheck()
    {
        if (PlayerPrefs.HasKey("SavedHighscore"))
        {
            if (_score > PlayerPrefs.GetInt("SavedHighscore"))
            {
                PlayerPrefs.SetInt("SavedHighscore", _score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SavedHighscore", _score);
        }
        _highscoreText.text = PlayerPrefs.GetInt("SavedHighscore").ToString();
    }
}
