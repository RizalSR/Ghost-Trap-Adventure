using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    [SerializeField]
    public GameObject A;
    [SerializeField]
    public GameObject B;

    public float Speed;
    void Start()
    {
        rb.GetComponents<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float weight = Mathf.Cos(Time.time * Speed * 2 * Mathf.PI) * 0.5f + 0.5f;
        transform.position = A.transform.position * weight + B.transform.position * (1-weight);
    }
}
