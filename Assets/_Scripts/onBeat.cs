using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class onBeat : MonoBehaviour {
    public int beatSection;
    public int groundMovement;
    public int spawnPositionSphere = 0;
    public GameObject[] _prefabEffect;
    public Transform[] _prefabPos;
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
        if (BeatPeer._beatCountX4 == 3 && BeatPeer._beatFull && !_enableBounce)
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
            effectInstance.transform.position = _prefabPos[0].position;
            _doOnce[0] = true;


          //  GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
          //  sphere.AddComponent<Rigidbody>();
          //  sphere.transform.position = new Vector3(spawnPositionSphere, spawnPositionSphere, 0);
        }
        if (beatSection == 16)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.AddComponent<Rigidbody>();
            sphere.transform.position = new Vector3(spawnPositionSphere, spawnPositionSphere, 0);
        }

        if (BeatPeer._beatFull)
        {
            Debug.Log("er is een beat nu");
        }

        
	}
}
