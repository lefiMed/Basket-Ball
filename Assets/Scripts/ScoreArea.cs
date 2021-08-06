using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject effect;
    void Start()
    {
        effect.SetActive(false);
    }


    void OnTriggerEnter(Collider collider)
    {        
        if (collider.GetComponent<Ball>() != null)
        {
            Debug.Log("Score");
            effect.SetActive(true);
        }
    }


}
