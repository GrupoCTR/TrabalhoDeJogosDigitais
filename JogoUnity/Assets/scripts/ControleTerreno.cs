using UnityEngine;
using System.Collections;

public class ControleTerreno : MonoBehaviour {

	private float comprimentoTerreno; // eixo y
	private float larguraTerreno; // eixo x

	public float GetComprimento { get { return comprimentoTerreno; } }
	public float GetLargura { get { return larguraTerreno; } }
	public GameObject GetTerreno { get { return gameObject; } }

	// Use this for initialization
	void Start () {
		comprimentoTerreno = gameObject.renderer.bounds.size.y;
		larguraTerreno = gameObject.renderer.bounds.size.x;
		//Debug.Log (comprimentoTerreno);
		//Debug.Log (larguraTerreno);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
