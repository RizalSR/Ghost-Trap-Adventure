using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed = 300.0f;
    [SerializeField]
    private Rigidbody2D rb;

    void Start()
    {
        rb.GetComponents<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            rb.isKinematic = false;
            rb.AddForce(Vector2.down*speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            Debug.Log("Got You!!");
        }
    }
}
