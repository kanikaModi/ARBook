using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour {
    public float moveX, moveY, moveZ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(moveX, moveY, moveZ) * Time.deltaTime);
	}
}
