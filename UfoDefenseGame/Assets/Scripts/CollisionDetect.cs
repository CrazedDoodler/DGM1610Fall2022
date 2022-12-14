using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreToGive;
    public AudioClip defeatSounds;
    private AudioSource enemyAudio;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //find and reference ScoreManager
        enemyAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(gameObject);
        Destroy(other.gameObject);
        enemyAudio.PlayOneShot(defeatSounds, 1.0f);
    }
}
