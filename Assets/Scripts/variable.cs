using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class variable : MonoBehaviour {
	public int value = 0;
	[HideInInspector] public float lastFrame;
	[HideInInspector] public Vector3 movement;
	[HideInInspector] public Vector3 initial;
	// Use this for initialization
	void Awake () {
		movement = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponentInChildren<Text> ().text = this.name + "\n" + this.value;
		transform.position = Vector3.MoveTowards(transform.position, movement, 3*Time.deltaTime);
		//transform.Translate(movement*Time.deltaTime);
		/*if (Time.realtimeSinceStartup - lastFrame >= 1f) {
			movement = new Vector3 (0f, 0f, 0f);
			//Debug.Log ("movement stopped");
		}*/
	}

	public void Move(Vector3 toMove) {
		//lastFrame = Time.realtimeSinceStartup;
		movement = toMove+transform.position;
		//Debug.Log (Time.realtimeSinceStartup);
	}
}
