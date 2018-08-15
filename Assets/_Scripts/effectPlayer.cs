using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectPlayer : MonoBehaviour {

    // Use this for initialization
    public void cubeWall()
    {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.AddComponent<Rigidbody>();
                cube.transform.position = new Vector3(x, y, 0);
            }
        }
    }
    public void sphereDrop()
    {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.AddComponent<Rigidbody>();
                sphere.transform.position = new Vector3(x, y, 0);
            }
        }
    }
}
