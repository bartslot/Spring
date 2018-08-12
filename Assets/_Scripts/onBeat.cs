using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class onBeat : MonoBehaviour {
    public int beatSection;

    public int spawnPositionCubes = 0;

    public AudioMixer _audioMixer;
    // Use this for initialization
    void Start () {
        beatSection = 0;

    }
	
	// Update is called once per frame
	void Update ()
    {
		if (BeatPeer._beatCountX8 == 0 && BeatPeer._beatFull)
        {
               Debug.Log("8e beat #" + beatSection.ToString());
                beatSection++;
            _audioMixer.SetFloat("lowcutoff", Random.Range(500f, 10000f));
          //  _audioMixer.SetFloat("delayecho", Random.Range(500f, 10000f));

        }
        if (beatSection == 2)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.AddComponent<Rigidbody>();
            cube.transform.position = new Vector3(spawnPositionCubes, spawnPositionCubes, 0);
        }

        if (BeatPeer._beatFull)
        {
            Debug.Log("er is een beat nu");
        }

        
	}
}
