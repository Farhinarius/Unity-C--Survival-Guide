using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame updat
    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
