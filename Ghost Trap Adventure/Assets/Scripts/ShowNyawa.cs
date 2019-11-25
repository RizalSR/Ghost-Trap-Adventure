using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowNyawa : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Text>().text = Data.nyawa.ToString();

        if(Data.nyawa == 0){
            SceneManager.LoadScene("GameOver");
        }
    }
}
