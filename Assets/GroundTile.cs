using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner GroundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        GroundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Fire" || other.name == "Water")
        {
          
          // Invoke("GroundSpawner.deleteTiles",2);
        }
    }
}
