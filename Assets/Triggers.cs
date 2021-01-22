using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D othercollider)
    {
        if (othercollider.CompareTag("Player"))
        {
            Debug.Log("ok");
        }

        
    }
    
        
    


}
