using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour {

	public GameObject carPrefab;

	public GameObject coinCylinder;

	public GameObject conePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!GetComponent<Renderer> ().isVisible) {

			Destroy (this.carPrefab);

			Destroy (this.coinCylinder);

			Destroy (this.conePrefab);
		}
	}
		
}
