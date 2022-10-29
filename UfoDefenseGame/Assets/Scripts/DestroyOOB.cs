using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    public float topBounds = 90.0f;
    public float lowerBounds = -50.0f;
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            //Debug.Log("Game Over...");
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
