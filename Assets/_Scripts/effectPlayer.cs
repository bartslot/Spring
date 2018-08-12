using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectPlayer : MonoBehaviour {

    // Use this for initialization
    void Start()
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

    // Update is called once per frame
    void Update () {
		
	}
}
