using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script05 : MonoBehaviour
{
    int numEnemy = 3;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numEnemy; i++)
        {
            Debug.Log("Creating Enemy Number:" + i);
        }
        // for WhileLoop
        /* while(numEnemy > 0)
            * Debug.Log("There is an Enemy!");
            * numEnemy--;
        * */
        bool continue = false;

        do
        {
            print ("Hello World");
        }
        while(continue == true);

        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach(string item in strings)
        {
            print (item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
