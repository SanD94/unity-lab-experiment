using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody objectRb;
    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        objectRb.AddForce(Vector3.forward * -speed);
        if (transform.position.z < -20) Destroy(gameObject);
    }
    
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Hello World!");
    }
    
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger Processing");
    }
}
