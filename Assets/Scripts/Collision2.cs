using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collision2 : MonoBehaviour
{
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Water"))
        {
            Invoke("Restart", 0f);
           
        }
           

    }
    // Start is called before the first frame update
}