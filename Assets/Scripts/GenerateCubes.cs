using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour
{
    public PrimitiveType DefinedType;

    public int numberOfObjects;

    void Start()
    {
        DefineObjects(numberOfObjects);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject CreateObject(PrimitiveType _figure)
    {
        GameObject figure = GameObject.CreatePrimitive(_figure);
        return figure;
    }

    Vector3 GenerateRandomVector()
    {
        Vector3 randomVector;
        randomVector = new Vector3(Random.Range(7, 10), Random.Range(1, 5), Random.Range(1, 5));
        return randomVector;
    }

    void DefineObjects(int number)
    {
        GameObject[] objects = new GameObject[number];
        
        for (int i = 0; i < number; i++)
        {
            objects[i] = CreateObject(DefinedType);
            objects[i].transform.position = GenerateRandomVector();
        }
    }

}
