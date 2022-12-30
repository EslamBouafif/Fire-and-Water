    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject waterr, fire;
    public float speed;
    public Animation animbleu;
    public Animation animrouge;
    public float s;

    bool test = false;

    private void Start()
    {
        /*animbleu = gameObject.GetComponent<Animation>();
        animrouge = gameObject.GetComponent<Animation>();*/
    }

    private void Update()
    {
     
        animbleu["movegauchebleu"].speed = s;
        animbleu["movedroitebleu"].speed = s;
        animrouge["movegaucherouge"].speed = s;
        animrouge["movedroitrouge"].speed = s;



        if (Input.GetKeyDown("s")&&!test)
        {

            animrouge.Play("movedroitrouge");
            animbleu.Play("movegauchebleu");
            print("test1");

            test = true;

        }
        else if (Input.GetKeyDown("s") &&  test)
        {

            animrouge.Play("movegaucherouge");
            animbleu.Play("movedroitebleu");
            print("test2");

          test = false;

        }


    }
}
    
