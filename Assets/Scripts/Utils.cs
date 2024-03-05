using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Utils : MonoBehaviour
{
    private static int score = 0;    
    private static float speed = 3.5f;
    public TMP_Text scoreText;

    public void Start() {
        scoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
    }

    public int IncrementScore() {
        score++;
        scoreText.text = $"Score = {score}";
        return score;
    }
    
    public float GetSpeed() {
        return speed;
    }
    
    public void IncrementSpeed() {
        speed += 0.5f;
    }
}