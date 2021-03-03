using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform toAim;
    Vector3 directionToFace;
    Quaternion targetRotation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        directionToFace = toAim.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.red);
        targetRotation = Quaternion.LookRotation(directionToFace);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2); // smoothly move to targetRotation with specified time

        /*      without smooth
        directionToFace = toAim.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.red);
        transform.rotation = Quaternion.LookRotation(directionToFace); */
    }
}
