using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public MoveF MoveF;
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 20;
    public int numberofTiles = 10;
   public List<GameObject> activeTiles = new List<GameObject>();
    public GameObject player;
  
  
    private void Start()
    {
        MoveF = GameObject.FindObjectOfType<MoveF>();
       for (int i=0; i<=numberofTiles; i++)
        {
            if (i<3)
            {
                spawntile1(0);

            }
            else
            {
                spawntile1(Random.Range(1, 3));

            }   
        }
    }
    private void Update()
    {
        if(add())
            {
            spawntile1(Random.Range(1,3));
            deleteTiles();
            


        }
        
      
       
    }
    /*public void spawntile(int tileIndex)
    {
        
       GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn  , transform.rotation);
       
        activeTiles.Add(go);
        zSpawn += 19;//tileLength;
       
        


    }*/
    public void spawntile1 (int tileIndex)
    {
        GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward  * zSpawn , transform.rotation);
        activeTiles.Add(go);
        zSpawn += 20;
        print(zSpawn);
    }
    public void deleteTiles()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);

    }
    public bool add()
    {
        bool ground = false;
        for (int i=1; i<=10; i++)
        {
            if(activeTiles[i].transform.position.z<transform.position.z -10   )
            {
                ground = true;
            }
          
        }
        return (ground);
    }
    public bool del()
    {
        bool ground = false;
        for (int i = 0; i <= 10; i++)
        {
            if (activeTiles[i].transform.position.z < -100)
            {
                ground = true;
            }

        }
        return (ground);
    }

}

   
