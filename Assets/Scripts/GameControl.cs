using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Player player;
    private float count = 5f;

    void Start()
    {
        Debug.Log("Start GameControl");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.holdingBall == false)
        {
            count -= Time.deltaTime;
            if (count <= 0)
            {
                SceneManager.LoadScene("Game");
            }
        }
    }
}
