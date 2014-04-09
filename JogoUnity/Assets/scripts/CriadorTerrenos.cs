using UnityEngine;
using System.Collections;

public class CriadorTerrenos : MonoBehaviour {


	public ControleTerreno controleTerreno;
	public int tamanhoX;
	public int tamanhoY;
	public Vector2 inicio;

	private GameObject terreno;
	//private int tamanhoAtualX = 0;
	//private int tamanhoAtualY = 0;
	
	// Use this for initialization
	void Start () {
		terreno = controleTerreno.GetTerreno;
		float tamX = terreno.renderer.bounds.size.x;
		float tamY = terreno.renderer.bounds.size.y;
		Vector2 posicao = inicio;
		bool teste = true;
		for (int i = 0; i < tamanhoX; i++) {
			for (int j = 0; j < tamanhoY; j++) {
				Instantiate(terreno, posicao, terreno.transform.rotation);
				posicao.x += tamX;
			}
			posicao.y += tamY/2f;
			if(teste) {
				posicao.x = inicio.x+tamX/2f; teste = false;
			} else {
				posicao.x = inicio.x; teste = true;
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
