using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jump : MonoBehaviour {
    public int jumpForce = 10;
    private bool _canJump = false;
    private const int AuthoriseJumpCount = 2;
    private int _jumpCount = 0;
    private Rigidbody _rb;
    private GameObject _gameState;
    private bool _hasCollectible = false;

    public void Start() {
        _rb = GetComponent<Rigidbody>();
        _gameState = GameObject.Find("GameState");
    }

    public void Update() { 
        if (_canJump && Input.GetKeyDown(KeyCode.Space)) {
            DoJump();
        }

        HandleDeath();
    }

    private void DoJump() {
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        _jumpCount++;
        if (_jumpCount >= AuthoriseJumpCount) {
            _canJump = false;
        }
    }

    public void OnTriggerEnter(Collider otherObject) {
        if (otherObject.CompareTag("Platform")) {
            _gameState.GetComponent<Utils>().IncrementScore();
            ResetJump();
        } else if (!_hasCollectible && otherObject.CompareTag("Collectible")) {
            _hasCollectible = true;
            _gameState.GetComponent<Utils>().IncrementScore();
            Destroy(otherObject.gameObject);
        }
    }

    private void ResetJump() {
        _canJump = true;
        _jumpCount = 0;
        _hasCollectible = false;
    }

    private void HandleDeath() {
        if (_rb.position.y < -10f) {
            SceneManager.LoadScene(0);
        }
    }
}