using UnityEngine;
using System.Collections;

public class TestUI_main : MonoBehaviour {

//	public Texture2D texBG;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		GUI.Box (new Rect(0,0,100,40), "Main");
	}
}
