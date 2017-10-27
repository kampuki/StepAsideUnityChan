using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour {

	public Transform charactor;

	public GameObject carprefab;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (charactor.position.z > carprefab.transform.position.z) {

			Destroy (carprefab);
	}
}
}
