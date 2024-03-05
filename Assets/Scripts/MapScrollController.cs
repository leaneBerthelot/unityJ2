using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScrollController : MonoBehaviour
{

    public int scrollSpeed = 100;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
    }
}
