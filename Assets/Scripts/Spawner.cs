using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject collectible;
    private GameObject gameState;
    void Start() {
        gameState = GameObject.Find("GameState");
    }

    void OnTriggerExit(Collider other) {
        if(other.tag == "Collectible") {
            return;
        }
        
        int height = Random.Range(0, 3);
        int score = gameState.GetComponent<Utils>().IncrementScore();

        if (score % 5 == 0) {
            gameState.GetComponent<Utils>().IncrementSpeed();
        }
        Instantiate(collectible, new Vector3(25, height + 2f, 10), Quaternion.identity);
        Instantiate(other.GameObject(), new Vector3(17, height, 10), Quaternion.identity);
    }
}