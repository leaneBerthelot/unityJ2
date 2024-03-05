using TMPro;
using UnityEngine;

public class Utils : MonoBehaviour {
    private int _score = 0;    
    private float _speed = 3.5f;
    private TMP_Text _scoreText;

    public void Start() {
        _scoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
        _scoreText.text = $"Score = {_score}";
    }

    public void IncrementScore() {
        _score++;
        _scoreText.text = $"Score = {_score}";
    }
    
    public int GetScore() {
        return _score;
    }
    
    public float GetSpeed() {
        return _speed;
    }
    
    public void IncrementSpeed() {
        _speed += 0.5f;
    }
}