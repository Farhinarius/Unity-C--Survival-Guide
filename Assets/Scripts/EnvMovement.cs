using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvMovement : MonoBehaviour
{
    public Vector3 startPosition = new Vector3(0, 0, 0);
    public float speed = 3;
    public float changeTime = 1.5F;
    
    float timer;
    int direction = 1;
    Vector3 objPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

    void FixedUpdate() {
        objPosition = transform.position;
        objPosition.z += direction * speed * Time.deltaTime;
        transform.position = objPosition;
    }
}
