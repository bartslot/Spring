using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour {
    public float _bpm;
    public float _beats;
     float _seconds;
    float _timer;

	// Use this for initialization
	void Start () {
        _seconds = (60 / _bpm) * _beats;
        _timer = 0;

    }
	
	// Update is called once per frame
	void Update () {
        _timer += Time.deltaTime;
        if (_timer >= _seconds)
        {

            Destroy(this.gameObject);
        }

    }
}
