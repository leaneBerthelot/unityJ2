using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour {
    public GameObject collectible;
    private GameObject _gameState;

    public void Start() {
        _gameState = GameObject.Find("GameState");
    }

    public void OnTriggerExit(Collider other) {
        if (other.CompareTag("Collectible")) {
            return;
        }
        
        var height = Random.Range(0f, 2.5f);

        if (_gameState.GetComponent<Utils>().GetScore() % 5 == 0) {
            _gameState.GetComponent<Utils>().IncrementSpeed();
        }

        Instantiate(collectible, new Vector3(27, height + 1f, 10), Quaternion.identity);
        Instantiate(other.GameObject(), new Vector3(17, height, 10), Quaternion.identity);
    }
}