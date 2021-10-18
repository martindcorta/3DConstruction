using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncrementarEscala : MonoBehaviour
{
    float x = 1;
    float y = 1;
    float z = 1;
    Vector3 newSize;
    // Update is called once per frame
   

   
    void Start()
    {
        
            x = x + 0.1f;
            y = y + 0.1f;
            z = z + 0.1f;
            transform.localScale = new Vector3(x, y, z);
        

    }
}
