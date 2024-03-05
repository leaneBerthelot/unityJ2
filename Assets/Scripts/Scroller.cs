using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformScroller : MonoBehaviour {
    private GameObject gameState;

    void Start() {
        gameState = GameObject.Find("GameState");
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }
    void Update() {
        transform.Translate(Vector3.left * gameState.GetComponent<Utils>().GetSpeed() * Time.deltaTime);
    }
}