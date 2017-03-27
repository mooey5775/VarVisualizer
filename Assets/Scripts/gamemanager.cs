using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Event{
	public Event(){
	}

	public Event(string a,int b,int c,int d,int command){
		this.a = a;
		this.b = b;
		this.c = c;
		this.d = d;
		this.command = command;
	}

	public string a { get; set; }
	public int b { get; set; }
	public int c { get; set; }
	public int d { get; set; }
	public int command { get; set; }
};

public class gamemanager : MonoBehaviour {

	int tst=0;
	Queue<GameObject> q = new Queue<GameObject>();
	List<GameObject> values = new List<GameObject>();
	List<GameObject> lists = new List<GameObject>();
	List<GameObject> nodes = new List<GameObject>();
	int valueslength = 0;
	bool done = false;
	int step = 0;
	bool[] welldone = new bool[26];

	/*
	 * 

		instantiateValue ("fibnums", 10);

		instantiateList (getValue(0), "f");
		instantiateList (3, "f2");
		instantiateValue ("fibnums132", 12);
		instantiateValue ("fibnums1", 0);
		instantiateValue ("fibnums4");
		instantiateList (getValue(2), "lsit2");
*/


	public int sp = 4;
	// Use this for initialization
	void Start () {
		/*q.Enqueue (new Event ("name", 0, 0, 0, 0));
		q.Enqueue (new Event ("name", 69, 0, 0, 1));
		q.Enqueue (new Event ("name", 0, 0, 0, 2));
		q.Enqueue (new Event ("name", 10, 0, 0, 3));
		q.Enqueue (new Event ("", 0, 0, 69, 4));
		q.Enqueue (new Event ("", 0, 1, 0, 5));
		q.Enqueue (new Event ("name", 69, 0, 0, 6));*/
		/*instantiateValue ("fibnums", 10);

		instantiateList (getValue(0), "f");
		instantiateList (3, "f2");
		instantiateValue ("fibnums132", 12);
		instantiateValue ("fibnums1", 0);
		instantiateValue ("fibnums4");
		instantiateList (getValue(2), "lsit2");
		instantiateListValue (0, 0, 12);
		instantiateListValue (0, 1, 10);
		instantiateListValue (1, 0, 35);
		instantiateExistingListValue (0, 2, 0);
		instantiateExistingListValue (0, 9, 2);
		instantiateExistingListValue (1, 1, 3);
		instantiateExistingListValue (0, 3, 2);
		instantiateExistingListValue (0, 4, 2);
		instantiateExistingListValue (0, 5, 2);
		instantiateExistingListValue (0, 6, 2);
		instantiateExistingListValue (0, 7, 2);
		instantiateExistingListValue (0, 8, 2);*/
		//updateVariable ("fibnums132", 69);

		instantiateValue ("fibnums", 10);
		instantiateValue ("fibindex");
		instantiateList (10, "fib");
		instantiateValue ("default", 1);
		instantiateValue ("zero", 0);

	}

	public Vector3 getPosition(){
		sp -= 3;
		return new Vector3 (-10, sp==-4? -5:sp + 3, 0);
	}

	// Update is called once per frame
	void Update () {
		/*if (Time.realtimeSinceStartup>10 && !done) {
			updateVariable ("fibnums132", 69);
			updateArrayValue (0, 2, 100);
			done = true;
			//Debug.Log ("move");
		}*/
		step = (int)Time.realtimeSinceStartup / 4;
		switch (step) {
		case 0:
			if (!welldone [0]) {
				welldone [0] = true;
				//updateArrayValue (0, 0, 1);
				//updateArrayValue (0, 1, 1);
				Debug.Log(tst++);
			}
			break;
		case 1:
			if (!welldone [1]) {
				for (int i = 0; i < 10; i++) {
					if (i<2)
						instantiateExistingListValue (0, i, 2 );
					else
						instantiateExistingListValue (0, i, 3);
				}
				welldone [1] = true;
				Debug.Log(tst++);
			}
			break;
		case 2:
			if (!welldone [2]) {
				welldone [2] = true;
				Debug.Log ("run1");
				updateVariable ("fibindex", 2);
				//Debug.Log ("sdflkjsdfjlksdf");
				Debug.Log(tst++);
			}
			break;
		case 3:
			if (!welldone [3]) {
				Debug.Log ("run2");
				welldone[3] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-1, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 4:
			if (!welldone [4]) {
				welldone [4] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-2, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 5:
			if (!welldone [5]) {
				welldone [5] = true;
				updateVariable ("fibindex", 3);
				Debug.Log(tst++);

			}
			break;
		case 6:
			if (!welldone [6]) {
				welldone [6] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-1, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 7:
			if (!welldone [7]) {
				welldone [7] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-2, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 8:
			if (!welldone [8]) {
				welldone [8] = true;
				updateVariable ("fibindex", 4);
				Debug.Log(tst++);
			}
			break;
		case 9:
			if (!welldone [9]) {
				welldone [9] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-1, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 10:
			if (!welldone [10]) {
				welldone [10] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-2, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 11:
			if (!welldone [11]) {
				welldone [11] = true;
				updateVariable ("fibindex", 5);
				Debug.Log(tst++);
			}
			break;
		case 12:
			if (!welldone [12]) {
				welldone [12] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-1, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 13:
			if (!welldone [13]) {
				welldone [13] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-2, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 14:
			if (!welldone [14]) {
				welldone [14] = true;
				updateVariable ("fibindex", 6);
				Debug.Log(tst++);
			}
			break;
		case 15:
			if (!welldone [15]) {
				welldone [15] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-1, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 16:
			if (!welldone [16]) {
				welldone [16] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-2, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 17:
			if (!welldone [17]) {
				welldone [17] = true;
				updateVariable ("fibindex", 7);
				Debug.Log(tst++);
			}
			break;
		case 18:
			if (!welldone [18]) {
				welldone [18] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-1, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 19:
			if (!welldone [19]) {
				welldone [19] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-2, getValue(1));
				Debug.Log(tst++);
			}
			break;
		case 20:
			if (!welldone [20]) {
				welldone [20] = true;
				updateVariable ("fibindex", 8);
			}
			break;
		case 21:
			if (!welldone [21]) {
				welldone [21] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-1, getValue(1));
			}
			break;
		case 22:
			if (!welldone [22]) {
				welldone [22] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-2, getValue(1));
			}
			break;
		case 23:
			if (!welldone [23]) {
				welldone [23] = true;
				updateVariable ("fibindex", 9);
			}
			break;
			break;
		case 24:
			if (!welldone [24]) {
				welldone [24] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-1, getValue(1));
			}
			break;
		case 25:
			if (!welldone [25]) {
				welldone [25] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-2, getValue(1));
			}
			break;
		/*case 23:
			if (!welldone [9]) {
				welldone [9] = true;
				updateVariable ("fibindex", 6);
			}
			break;
			break;
		case 21:
			if (!welldone [9]) {
				welldone [9] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-1, getValue(1));
			}
			break;
		case 22:
			if (!welldone [9]) {
				welldone [9] = true;
				incrementArrayValueByArrayIndex (0, getValue(1)-2, getValue(1));
			}
			break;
		case 23:
			if (!welldone [9]) {
				welldone [9] = true;
				updateVariable ("fibindex", 6);
			}
			break;*/
		}

	}
		
	int getValue(int index){
		return values [index].GetComponent<variable> ().value;
	}

	void incrementArrayValueByArrayIndex(int list, int index, int otherindex) {
		GameObject a = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		a.transform.SetParent (lists [list].transform);
		a.transform.position = lists [list].transform.position + new Vector3 (0f, 0f, (index + 1) * (5 / 6f));
		a.name = otherindex.ToString ();
		a.AddComponent<variable> ();
		foreach (GameObject geo in nodes) {
			if (geo.name == index.ToString () && geo.transform.parent == lists[list].transform) {
								a.GetComponent<variable>().value = geo.GetComponent<variable>().value;
								break;
			}
		}
		

		GameObject c = new GameObject();
		c.name="Canvas";
		c.AddComponent<Canvas> ();
		c.AddComponent<RectTransform> ();
		c.AddComponent<CanvasScaler> ();
		c.AddComponent<GraphicRaycaster> ();

		c.GetComponent<Canvas> ().renderMode = RenderMode.WorldSpace;
		c.transform.SetParent(a.transform);
		c.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 1f, 0f);
		c.GetComponent<RectTransform> ().transform.Rotate (new Vector3(0, -90, 0));

		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 1);
		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 1);
		//c.GetComponent<RectTransform> ().localScale = new Vector3 (1f, 1f, 1f);
		c.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		c.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);


		GameObject t = new GameObject();
		t.AddComponent<Text> ();
		t.GetComponent<Text>().text=a.GetComponent<variable>().value.ToString();
		t.name="Text";
		t.GetComponent<Text>().fontSize=30;
		t.GetComponent<Text>().alignment=TextAnchor.LowerCenter;
		t.GetComponent<Text>().font=Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
		t.AddComponent<RectTransform> ();
		t.AddComponent<CanvasRenderer> ();

		t.transform.SetParent(c.transform);
		t.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 0f, 0f);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 300);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 100);
		t.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().transform.localRotation = Quaternion.identity;
		t.GetComponent<RectTransform> ().localScale = new Vector3 (0.01f, 0.01f, 0.01f);

		variable z = (variable)a.GetComponent (typeof(variable));
		z.Move (new Vector3 (0f, 0f, (otherindex - index) * (5 / 6f)));
						foreach (GameObject geo in nodes) {
							if (geo.name == otherindex.ToString () && geo.transform.parent == lists[list].transform) {
								a.GetComponent<variable>().value+=geo.GetComponent<variable>().value;
								break;
							}
						}

		updateArrayValue (list, otherindex, a.GetComponent<variable> ().value);

		//a.SetActive (false);

	}
				

	void updateVariable(string name, int value) {
		for (int index = 0; index < valueslength; index++) { 
			if (values [index].name == name) {
				values [index].GetComponent<variable> ().value = value;
			}
		}
	}

	void updateArrayValue(int list, int index, int value) {
		foreach (GameObject geo in nodes) {
			if (geo.name == index.ToString () && geo.transform.parent == lists[list].transform) {
				nodes.Remove (geo);
				Destroy (geo);
				instantiateListValue (list, index, value);
				return;
			}
		}
	}

	void instantiateExistingListValue(int list, int index, int existing) {
		GameObject a = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		a.transform.SetParent (lists [list].transform);
		a.transform.position = values [existing].transform.position;
		a.name = index.ToString ();
		a.AddComponent<variable> ();
		a.GetComponent<variable>().value = values[existing].GetComponent<variable>().value;

		GameObject c = new GameObject();
		c.name="Canvas";
		c.AddComponent<Canvas> ();
		c.AddComponent<RectTransform> ();
		c.AddComponent<CanvasScaler> ();
		c.AddComponent<GraphicRaycaster> ();

		c.GetComponent<Canvas> ().renderMode = RenderMode.WorldSpace;
		c.transform.SetParent(a.transform);
		c.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 1f, 0f);
		c.GetComponent<RectTransform> ().transform.Rotate (new Vector3(0, -90, 0));

		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 1);
		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 1);
		//c.GetComponent<RectTransform> ().localScale = new Vector3 (1f, 1f, 1f);
		c.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		c.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);


		GameObject t = new GameObject();
		t.AddComponent<Text> ();
		t.GetComponent<Text>().text=values[existing].GetComponent<variable>().value.ToString();
		t.name="Text";
		t.GetComponent<Text>().fontSize=30;
		t.GetComponent<Text>().alignment=TextAnchor.LowerCenter;
		t.GetComponent<Text>().font=Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
		t.AddComponent<RectTransform> ();
		t.AddComponent<CanvasRenderer> ();

		t.transform.SetParent(c.transform);
		t.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 0f, 0f);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 300);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 100);
		t.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().transform.localRotation = Quaternion.identity;
		t.GetComponent<RectTransform> ().localScale = new Vector3 (0.01f, 0.01f, 0.01f);

		nodes.Add (a);

		variable z = (variable)a.GetComponent (typeof(variable));
		z.Move (new Vector3 (0f, 0f, (index+1)*(5/6f))+lists[list].transform.position-a.transform.position);
	}

	void instantiateListValue(int list, int index, int value) {
		GameObject a = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		a.transform.SetParent (lists [list].transform);
		a.transform.localPosition = new Vector3 (10f, 0f, (index+1)*(5/6f));
		a.name = index.ToString ();
		a.AddComponent<variable> ();
		a.GetComponent<variable>().value = value;

		GameObject c = new GameObject();
		c.name="Canvas";
		c.AddComponent<Canvas> ();
		c.AddComponent<RectTransform> ();
		c.AddComponent<CanvasScaler> ();
		c.AddComponent<GraphicRaycaster> ();

		c.GetComponent<Canvas> ().renderMode = RenderMode.WorldSpace;
		c.transform.SetParent(a.transform);
		c.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 1f, 0f);
		c.GetComponent<RectTransform> ().transform.Rotate (new Vector3(0, -90, 0));

		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 1);
		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 1);
		//c.GetComponent<RectTransform> ().localScale = new Vector3 (1f, 1f, 1f);
		c.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		c.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);


		GameObject t = new GameObject();
		t.AddComponent<Text> ();
		t.GetComponent<Text>().text=value.ToString();
		t.name="Text";
		t.GetComponent<Text>().fontSize=30;
		t.GetComponent<Text>().alignment=TextAnchor.LowerCenter;
		t.GetComponent<Text>().font=Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
		t.AddComponent<RectTransform> ();
		t.AddComponent<CanvasRenderer> ();

		t.transform.SetParent(c.transform);
		t.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 0f, 0f);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 300);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 100);
		t.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().transform.localRotation = Quaternion.identity;
		t.GetComponent<RectTransform> ().localScale = new Vector3 (0.01f, 0.01f, 0.01f);
	
		nodes.Add (a);

		variable z = (variable)a.GetComponent (typeof(variable));
		z.Move (new Vector3 (-10f, 0f, 0f));
	}

	void instantiateValue(string name){

		valueslength++;
		GameObject a = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		a.transform.position = getPosition ();
		a.name = name;
		a.AddComponent<variable>();
		a.GetComponent<variable>().value = 0;


		GameObject c = new GameObject();
		c.name="Canvas";
		c.AddComponent<Canvas> ();
		c.AddComponent<RectTransform> ();
		c.AddComponent<CanvasScaler> ();
		c.AddComponent<GraphicRaycaster> ();

		c.GetComponent<Canvas> ().renderMode = RenderMode.WorldSpace;
		c.transform.SetParent(a.transform);
		c.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 1f, 0f);
		c.GetComponent<RectTransform> ().transform.Rotate (new Vector3(0, -90, 0));

		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 1);
		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 1);
		//c.GetComponent<RectTransform> ().localScale = new Vector3 (1f, 1f, 1f);
		c.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		c.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);


		GameObject t = new GameObject();
		t.AddComponent<Text> ();
		t.GetComponent<Text> ().text = name + "\nnull";
		t.name="Text";
		t.GetComponent<Text>().fontSize=30;
		t.GetComponent<Text>().alignment=TextAnchor.LowerCenter;
		t.GetComponent<Text> ().font = Resources.GetBuiltinResource (typeof(Font), "Arial.ttf") as Font;
			t.AddComponent<RectTransform> ();
		t.AddComponent<CanvasRenderer> ();

		t.transform.SetParent(c.transform);
		t.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 0f, 0f);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 300);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 100);
		t.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().transform.localRotation= Quaternion.identity;
		t.GetComponent<RectTransform> ().localScale = new Vector3 (0.01f, 0.01f, 0.01f);




		values.Add(a);

	}

	void instantiateValue(string name, int value){
				valueslength++;

		GameObject a = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		a.transform.position = getPosition ();
		a.name = name;
		a.AddComponent<variable>();
		values.Add(a);

		a.GetComponent<variable>().value = value;

		GameObject c = new GameObject();
		c.name="Canvas";
		c.AddComponent<Canvas> ();
		c.AddComponent<RectTransform> ();
		c.AddComponent<CanvasScaler> ();
		c.AddComponent<GraphicRaycaster> ();

		c.GetComponent<Canvas> ().renderMode = RenderMode.WorldSpace;
		c.transform.SetParent(a.transform);
		c.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 1f, 0f);
		c.GetComponent<RectTransform> ().transform.Rotate (new Vector3(0, -90, 0));

		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 1);
		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 1);
		//c.GetComponent<RectTransform> ().localScale = new Vector3 (1f, 1f, 1f);
		c.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		c.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);


		GameObject t = new GameObject();
		t.AddComponent<Text> ();
		t.GetComponent<Text>().text=name+"\n"+value.ToString();
		t.name="Text";
		t.GetComponent<Text>().fontSize=30;
		t.GetComponent<Text>().alignment=TextAnchor.LowerCenter;
		t.GetComponent<Text>().font=Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
		t.AddComponent<RectTransform> ();
		t.AddComponent<CanvasRenderer> ();

		t.transform.SetParent(c.transform);
		t.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 0f, 0f);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 300);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 100);
		t.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().transform.localRotation = Quaternion.identity;
		t.GetComponent<RectTransform> ().localScale = new Vector3 (0.01f, 0.01f, 0.01f);

	}

	void instantiateList(string name){
		GameObject b = new GameObject ();
		b.transform.position = getPosition ();
		b.name = name;
		lists.Add (b);

		GameObject child = GameObject.CreatePrimitive (PrimitiveType.Cube);
		child.name = "head "+name;
		//child.AddComponent<variable> ();
		child.transform.SetParent (b.transform);

		child.transform.position = new Vector3 (b.transform.position.x, b.transform.position.y, 0);

		//Debug.Log ("head child added");


		GameObject c = new GameObject();
		c.name="Canvas";
		c.AddComponent<Canvas> ();
		c.AddComponent<RectTransform> ();
		c.AddComponent<CanvasScaler> ();
		c.AddComponent<GraphicRaycaster> ();

		c.GetComponent<Canvas> ().renderMode = RenderMode.WorldSpace;
		c.transform.SetParent(b.transform);
		c.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (.51f, 0f, 0f);
		c.GetComponent<RectTransform> ().transform.Rotate (new Vector3(0, -90, 0));

		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 1);
		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 1);
		//c.GetComponent<RectTransform> ().localScale = new Vector3 (1f, 1f, 1f);
		c.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		c.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);


		GameObject t = new GameObject();
		t.AddComponent<Text> ();
		t.GetComponent<Text>().text=name;
		t.name="Text";
		t.GetComponent<Text>().fontSize=30;
		t.GetComponent<Text>().color=Color.black;
		t.GetComponent<Text>().font=Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
		t.AddComponent<RectTransform> ();
		t.AddComponent<CanvasRenderer> ();

		t.transform.SetParent(c.transform);
		t.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 0f, 0f);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 100);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 100);
		t.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().transform.localRotation= Quaternion.identity;
		t.GetComponent<RectTransform> ().localScale = new Vector3 (0.01f, 0.01f, 0.01f);

	}

	void instantiateList(int size, string name){
		GameObject b = new GameObject ();
		b.transform.position = getPosition ();
		b.name = name;
		lists.Add(b);

		for (int i = -1; i < size; i++) {
			if (i == -1) {
				GameObject child = GameObject.CreatePrimitive (PrimitiveType.Cube);
				child.name = "head cube";
				//child.AddComponent<variable> ();
				child.transform.SetParent (b.transform);

				child.transform.position = new Vector3 (b.transform.position.x, b.transform.position.y, (i+1) * (1 - 1 / 8f));

				//Debug.Log ("head child added");
			} else {


				GameObject child = GameObject.CreatePrimitive (PrimitiveType.Cube);
				child.name = "cube " + i.ToString ();

				//child.AddComponent<variable> ();

				Mesh mesh = GameObject.FindGameObjectWithTag ("CubePrefab").GetComponent<MeshFilter> ().mesh;
				child.GetComponent<MeshFilter> ().mesh = mesh;


				child.transform.SetParent (b.transform);

				child.transform.position = new Vector3 (b.transform.position.x - .5f, b.transform.position.y - .5f, (i+1) * (1 - 1 / 6f) + .5f);



				//Debug.Log ("child added");
			}
		}

		GameObject c = new GameObject();
		c.name="Canvas";
		c.AddComponent<Canvas> ();
		c.AddComponent<RectTransform> ();
		c.AddComponent<CanvasScaler> ();
		c.AddComponent<GraphicRaycaster> ();

		c.GetComponent<Canvas> ().renderMode = RenderMode.WorldSpace;
		c.transform.SetParent(b.transform);
		c.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (.51f, 0f, 0f);
		c.GetComponent<RectTransform> ().transform.Rotate (new Vector3(0, -90, 0));

		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 1);
		c.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 1);
		//c.GetComponent<RectTransform> ().localScale = new Vector3 (1f, 1f, 1f);
		c.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		c.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);


		GameObject t = new GameObject();
		t.AddComponent<Text> ();
		t.GetComponent<Text>().text=name;
		t.name="Text";
		t.GetComponent<Text>().fontSize=30;
		t.GetComponent<Text>().color=Color.black;
		t.GetComponent<Text>().font=Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
		t.AddComponent<RectTransform> ();
		t.AddComponent<CanvasRenderer> ();

		t.transform.SetParent(c.transform);
		t.GetComponent<RectTransform> ().transform.localPosition = new Vector3 (0f, 0f, 0f);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 100);
		t.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 100);
		t.GetComponent<RectTransform> ().anchorMax = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().anchorMin = new Vector2 (.5f,.5f);
		t.GetComponent<RectTransform> ().transform.localRotation = Quaternion.identity;
		t.GetComponent<RectTransform> ().localScale = new Vector3 (0.01f, 0.01f, 0.01f);

	}
}
