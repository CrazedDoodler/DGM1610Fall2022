using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject projectile;
    public Transform itemDrop;
    public GameObject item;
    public GameManager gameManager;
    public AudioClip deathSounds;
    public AudioClip shootSounds;
    private AudioSource playerAudio;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // set horizontal to recieve from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        // moves player left+right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep player in bounds (Left)
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Keep player in bounds (Right)
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            //creates projectile for blaster
            Instantiate(projectile, blaster.transform.position, projectile.transform.rotation);
            //plays shoot sound
            playerAudio.PlayOneShot(shootSounds, 1.0f);
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            //creates item for item drop
            Instantiate(item, itemDrop.transform.position, item.transform.rotation);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        playerAudio.PlayOneShot(deathSounds, 1.0f);
    }
}
