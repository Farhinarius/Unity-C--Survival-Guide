using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] array;
    
    void Start()
    {
        foreach (int arrElem in array)
        {
            Debug.Log(arrElem);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
