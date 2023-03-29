using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsMoveForward : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * Time.deltaTime * speed;
    }
}
