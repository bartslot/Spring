using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour {

    internal Rigidbody Rbody;
    
    // Use this for initialization
	internal void Start () {
        this.gameObject.AddComponent<Rigidbody>();
        this.Rbody = this.gameObject.GetComponent<Rigidbody>();
        this.Rbody.isKinematic = true;

        int childCount = this.transform.childCount;

        for(int i = 0; i < childCount; i++)
        {
            Transform t = this.transform.GetChild(i);

            t.gameObject.AddComponent<HingeJoint>();

            HingeJoint hinge = t.gameObject.GetComponent<HingeJoint>();

            hinge.connectedBody =
                i == 0 ? this.Rbody :
                this.transform.GetChild(i - 1).GetComponent<Rigidbody>();

            hinge.useSpring = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
