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
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
            Time.timeScale = 1;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag.Equals("Paku"))
        {
            if(Data.nyawa == 1)
            {
                isDead = true;
                anim.SetTrigger("Dead");
                Data.nyawa --;
            } else {
                Data.score = 0;
                isDead = true;
                anim.SetTrigger("Dead");
                Data.nyawa --;
            }
        }

        if (other.transform.tag.Equals("Enemy"))
        {
            if(Data.nyawa == 1)
            {
                isDead = true;
                anim.SetTrigger("Dead");
                Data.nyawa --;
            } else {
                Data.score = 0;
                isDead = true;
                anim.SetTrigger("Dead");
                Data.nyawa --;
            }
        }
    }
}
