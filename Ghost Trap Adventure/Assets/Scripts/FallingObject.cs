using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingObject : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed = 300.0f;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    public Transform spawnPoint;

    public GameObject safe;

    private bool disableTrap = false;

    void Start()
    {
        rb.GetComponents<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (disableTrap == false)
        {
            if (other.gameObject.name.Equals("Player"))
            {
                rb.isKinematic = false;
                rb.AddForce(Vector2.down*speed);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (disableTrap == false)
        {
            if (other.gameObject.name.Equals("Player"))
            {
                int scene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(scene, LoadSceneMode.Single);
                Time.timeScale = 1;
            }

            if (safe)
            {
                disableTrap = true;
                gameObject.layer = 8;
            }
        }
        

    }
}
