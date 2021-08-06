using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Trail;

    void Start()
    {
        Trail.SetActive(false);
    }

    public void activateTrail()
    {
        Trail.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
