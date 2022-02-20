using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DestoryWhenOutBounds : MonoBehaviour
{
    public float Bound;
    public int Id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Id 1 = Food
        Id 2 = animals
        */

        if( transform.position.z >  Bound && Id == 1) Destroy(gameObject);
        else if (transform.position.z < Bound && Id == 2) Destroy(gameObject);
    }
}
