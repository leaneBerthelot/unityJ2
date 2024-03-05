using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCollectible : MonoBehaviour
{
    private GameObject gameState;
    void Start()
    {
        gameState = GameObject.Find("GameState");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collectible collided with " + other.tag);
        if (other.tag != "Player")
        {
            return;
        }

        Debug.Log("Collectible collided with " + other.tag);
        gameState.GetComponent<Utils>().IncrementScore();
        Destroy(gameObject);
    }
}
