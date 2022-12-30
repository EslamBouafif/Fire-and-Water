 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Collision : MonoBehaviour
{
    public TMP_Text TextScore;
    int s = 0;
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if ((collider.gameObject.CompareTag("Fire"))|| (collider.gameObject.CompareTag("Water")))
            {
            s++;
            TextScore.text = s.ToString();
        }
        if (collider.gameObject.CompareTag("Fire"))
        {
            Restart();
             

}
       
        
    }
    // Start is called before the first frame update
}
