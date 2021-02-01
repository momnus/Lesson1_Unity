using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("Camera Hight:" + gameObject.transform.position.y);
    }
}
