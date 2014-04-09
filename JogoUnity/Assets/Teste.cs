using UnityEngine;
using System.Collections;

public class Teste : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (PlayerPrefs.GetInt ("LarguraCenario"));
		Debug.Log (PlayerPrefs.GetInt ("AlturaCenario"));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
