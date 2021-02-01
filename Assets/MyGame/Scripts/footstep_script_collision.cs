using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstep_script_collision: MonoBehaviour
{
     public AK.Wwise.Event footevent; // выбираем ивент Wwise

    private void OnTriggerEnter(Collider other)
    {
        var Material = other.gameObject.tag;
        print(Material);
       // AkSoundEngine.SetSwitch("Terrain", Material, this.gameObject);
        // footevent.Post(gameObject);

    }

}
