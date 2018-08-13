using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class onBeat : MonoBehaviour {
    public int beatSection;
    public int groundMovement;
    public int spawnPositionSphere = 0;

    public GameObject[] _prefabEffect;
    public GameObject[] _prefabWallSegment;
    public GameObject[] _prefabSphere;

    public Transform[] _prefabPosEffect;
    public Transform[] _prefabPosWallSegment;
    public Transform[] _prefabPosSphere;

    public AudioMixer _audioMixer;
    public Transform _groundplane;
    public AnimationCurve _groundbounceCurve;
    float _groundbounceTimer;
    bool _enableBounce;
    public float _bounceDistanceMultiplier;

    bool[] _doOnce;
    // Use this for initialization
    void Start () {
        _doOnce = new bool[5];
        beatSection = 0;
        groundMovement = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (BeatPeer._beatCountX4 == 3 && BeatPeer._beatFull && !_enableBounce && beatSection >= 16)
        {
            _enableBounce = true;
        }

        if (_enableBounce)
        {
            if (_groundbounceTimer < 1)
            {
                _groundbounceTimer += Time.deltaTime * 2;
                _groundplane.localPosition = new Vector3(_groundplane.localPosition.x, -20 - (_groundbounceCurve.Evaluate(_groundbounceTimer)* _bounceDistanceMultiplier), _groundplane.localPosition.z);
            }
            if (_groundbounceTimer >= 1)
            {
                _groundbounceTimer = 0;
                _enableBounce = false;
            }
        }

        if (BeatPeer._beatCountX8 == 0 && BeatPeer._beatFull)
        {
               Debug.Log("8e beat #" + beatSection.ToString());
                beatSection++;
           // transform.Translate(Vector3.up * Time.deltaTime, Space.World);
            //  _audioMixer.SetFloat("lowcutoff", Random.Range(500f, 10000f));
            //  _audioMixer.SetFloat("delayecho", Random.Range(500f, 10000f));

        }
        if (beatSection == 2 && BeatPeer._beatCountX8 == 0 && !_doOnce[0]) 
        {
            GameObject effectInstance = (GameObject)Instantiate(_prefabEffect[0]);
            effectInstance.transform.position = _prefabPosEffect[0].position;
            _doOnce[0] = true;


          //  GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
          //  sphere.AddComponent<Rigidbody>();
          //  sphere.transform.position = new Vector3(spawnPositionSphere, spawnPositionSphere, 0);
        }
        if (beatSection == 4 && BeatPeer._beatCountX8 == 0)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    GameObject cubeInstance = (GameObject)Instantiate(_prefabWallSegment[0]);
                    cubeInstance.transform.position = _prefabPosWallSegment[0].position;
                    _doOnce[0] = true;
                    cubeInstance.transform.position = new Vector3(x, y, 0);
                }
            }
        }
        if (beatSection == 10 && BeatPeer._beatCountX8 == 7 && !_doOnce[1])
        {
            GameObject effectInstance = (GameObject)Instantiate(_prefabEffect[1]);
            GameObject effectInstance2 = (GameObject)Instantiate(_prefabEffect[1]);
            GameObject effectInstance3 = (GameObject)Instantiate(_prefabEffect[1]);
            effectInstance.transform.position = _prefabPosEffect[0].position;
            effectInstance2.transform.position = _prefabPosEffect[1].position;
            effectInstance2.transform.position = _prefabPosEffect[2].position;
            _doOnce[1] = true;


            //  GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //  sphere.AddComponent<Rigidbody>();
            //  sphere.transform.position = new Vector3(spawnPositionSphere, spawnPositionSphere, 0);
        }
        if (beatSection == 10 && BeatPeer._beatCountX8 == 6 && !_doOnce[1])
        {
            GameObject effectInstance = (GameObject)Instantiate(_prefabEffect[1]);
            GameObject effectInstance2 = (GameObject)Instantiate(_prefabEffect[1]);
            GameObject effectInstance3 = (GameObject)Instantiate(_prefabEffect[1]);
            effectInstance.transform.position = _prefabPosEffect[0].position;
            effectInstance2.transform.position = _prefabPosEffect[1].position;
            effectInstance2.transform.position = _prefabPosEffect[2].position;
            _doOnce[1] = true;

        }
        if (beatSection == 2 && BeatPeer._beatCountX8 == 0 && !_doOnce[1])
        {
            GameObject effectInstance = (GameObject)Instantiate(_prefabEffect[2]);
            GameObject effectInstance2 = (GameObject)Instantiate(_prefabEffect[2]);
            GameObject effectInstance3 = (GameObject)Instantiate(_prefabEffect[2]);
            effectInstance.transform.position = _prefabPosEffect[0].position;
            effectInstance2.transform.position = _prefabPosEffect[1].position;
            effectInstance2.transform.position = _prefabPosEffect[2].position;
            GameObject effectInstance4 = (GameObject)Instantiate(_prefabEffect[2]);
            GameObject effectInstance5 = (GameObject)Instantiate(_prefabEffect[2]);
            GameObject effectInstance6 = (GameObject)Instantiate(_prefabEffect[2]);
            effectInstance4.transform.position = _prefabPosEffect[3].position;
            effectInstance5.transform.position = _prefabPosEffect[4].position;
            effectInstance6.transform.position = _prefabPosEffect[5].position;
            _doOnce[1] = true;

        }
        if (beatSection == 16 && BeatPeer._beatCountX8 == 0)
        {
            GameObject sphere = (GameObject)Instantiate(_prefabSphere[0]);
            sphere.transform.position = _prefabPosSphere[0].position;
            sphere.transform.position = new Vector3(spawnPositionSphere, spawnPositionSphere, 0);
        }

        if (BeatPeer._beatFull)
        {
            Debug.Log("er is een beat nu");
        }

        
	}
}
