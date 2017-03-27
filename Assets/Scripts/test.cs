using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
	public float speed = .1f;

	void Start () {
		
		Debug.Log ("*");
		for (int y = 0; y < 5; y++) {
			for (int x = 0; x < 5; x++) {
				GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
				//sphere.AddComponent<Rigidbody> ();
				sphere.tag = "sphere";
				sphere.transform.position = new Vector3 (x, y, 0);
			}
		}
		GameObject[] a = GameObject.FindGameObjectsWithTag ("sphere");
		for (int i = 0; i < a.Length; i++) {
			GameObject b = a [i];
			if (i==4) {
				Debug.Log (i);
			}
		}


	}
	

	void Update () {
		GameObject[] a = GameObject.FindGameObjectsWithTag ("sphere");
		for (int i = 0; i < a.Length; i++) {
			GameObject b = a [i];
			if (i==6) {
				b.transform.Translate (Vector3.right*speed);
			}
		}
	}
}
