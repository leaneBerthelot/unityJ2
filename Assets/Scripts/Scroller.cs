using UnityEngine;

public class Scroller : MonoBehaviour {
    private GameObject _gameState;

    public void Start() {
        _gameState = GameObject.Find("GameState");
    }

    public void OnBecameInvisible() {
        Destroy(gameObject);
    }

    public void Update() {
        transform.Translate(Vector3.left * _gameState.GetComponent<Utils>().GetSpeed() * Time.deltaTime);
    }
}