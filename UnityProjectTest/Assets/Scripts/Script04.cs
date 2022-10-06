using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script04 : MonoBehaviour
{
    float coffeeTemp = 85.0f;
    float hotLimit = 70.0f;
    float coldLimit = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TempTest();

        coffeeTemp -= Time.deltaTime * 5f;
    }

    void TemperatureTest ()
    {
        // If the coffeeTemp is greater than the hottest
        if(coffeeTemp > hotLimit)
        {
            print("Coffee is too Hot");
        }
        else if(coffeeTemp < coldLimit)
        {
            print("Coffee is too Cold");
        }
        else
        {
            print("Coffee is just Right");
        }
    }
}
