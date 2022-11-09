using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //find and reference ScoreManager
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
