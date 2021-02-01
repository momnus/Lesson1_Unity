using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_height : MonoBehaviour
{
   
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (camera.transform.position.y >= 0)
        { 
     //       AkSoundEngine.SetRTPCValue("Altitude", camera.transform.position.y);
        }
        else { 
     //       AkSoundEngine.SetRTPCValue("Altitude", 0); print("LowAir");
        }
       
    }
}
