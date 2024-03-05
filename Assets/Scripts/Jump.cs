using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jump : MonoBehaviour
{
    public int jumpForce = 10;
    private bool canJump = false;
    public GameObject ground;
    private int authoriseJumpCount = 2;
    private int jumpCount = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    { 
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            DoJump();
        }
        handleDeath();
    }

    void DoJump()
    {
        
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        jumpCount++;
        if(jumpCount >= authoriseJumpCount)
        {
            canJump = false;
        }
    }

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Platform")
        {
            resetJump();
        }
    }

    void resetJump()
    {
        canJump = true;
        jumpCount = 0;
    }

    void handleDeath()
    {
        if (rb.position.y < -10f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
