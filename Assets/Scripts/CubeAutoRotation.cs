using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAutoRotation : MonoBehaviour
{
    public Vector3 rotationDirection;
    public float durationTime;
    public float angle;

    // Start is called before the first frame update
    void Start()
    {
/*      currentLocation = transform.position;
        currentLocation.z += 2;
        Instantiate(this, currentLocation, Quaternion.identity); */

        // glide up
        transform.position += new Vector3(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, rotationDirection, angle * Time.deltaTime);
    }
}
