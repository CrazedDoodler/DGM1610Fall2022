using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item Get!");
        Destroy(gameObject);
        //Destroy(other.gameObject);
    }
}
