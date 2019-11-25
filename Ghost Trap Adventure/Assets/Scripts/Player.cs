using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private bool isDead = false;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true){
            
            SceneManager.LoadScene("Level2");
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag.Equals("Paku")){
            isDead = true;
            anim.SetTrigger("Dead");
            Data.nyawa --;
        }
    }
}
