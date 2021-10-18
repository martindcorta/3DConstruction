using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Movimiento_cubo : MonoBehaviour
{

    void Update()

    {
        //if ///(Input.GetKey(KeyCode.D))

        transform.Rotate(new Vector3(0f, 0f, -5f) * Time.deltaTime);



    }


}