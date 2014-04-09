using UnityEngine;
using System.Collections;

public class ControleAberturaNovoCenario : MonoBehaviour {

	public string larguraCenario;
	public string alturaCenario;

	public float alturaCaixaCaptura;
	public float larguraCaixaCaptura;

	public float larguraTextField;
	public float alturaTextField;

	public float larguraBotao;
	public float alturaBotao;

	private bool mostrarGUI;
	private float larguraTela;
	private float alturaTela;

	// Use this for initialization
	void Start () {
		mostrarGUI = false;
		larguraTela = Screen.width;
		alturaTela = Screen.height;
	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnMouseUpAsButton() {
		mostrarGUI = true;
	}

	void OnGUI() {
		if (mostrarGUI) {
			CapturarDimensoes();
		}


	}

	void CapturarDimensoes() {
		float posX = (larguraTela - larguraCaixaCaptura) / 2f;
		float posY = (alturaTela - alturaCaixaCaptura) / 2f;
		GUI.Box(new Rect(posX, posY, larguraCaixaCaptura, alturaCaixaCaptura), "Loader Menu");

		float posXTextField = posX + (larguraCaixaCaptura - larguraTextField) / 2f;
		float posYTextField = posY + (alturaCaixaCaptura - alturaTextField) / 4f;
		larguraCenario = GUI.TextField(new Rect(posXTextField, posYTextField, larguraTextField, alturaTextField), 
		                               larguraCenario, 
		                               25);
		GUI.Label(new Rect(posXTextField-larguraTextField*0.80f, posYTextField, larguraTextField, alturaTextField*1.1f), 
		          "Largura");

		posYTextField = posY + alturaTextField + (alturaCaixaCaptura - alturaTextField) / 3f;
		alturaCenario = GUI.TextField(new Rect(posXTextField, posYTextField, larguraTextField, alturaTextField), 
		                              alturaCenario, 
		                              25);
		GUI.Label(new Rect(posXTextField-larguraTextField*0.80f, posYTextField, larguraTextField, alturaTextField*1.1f),
		          "Altura");
	
		float posXBotao = posX + (larguraCaixaCaptura - larguraBotao) / 2f;
		float posYBotao = posY + (alturaCaixaCaptura - alturaBotao) / 1.2f;
		if(GUI.Button(new Rect(posXBotao, posYBotao, larguraBotao, alturaBotao)
			,"Prosseguir")) {
			int altCenario, larCenario;
			if(int.TryParse(larguraCenario, out larCenario) && int.TryParse(alturaCenario, out altCenario)) {
				Debug.Log(larCenario);
				Debug.Log(altCenario);
				PlayerPrefs.SetInt("LarguraCenario", larCenario);
				PlayerPrefs.SetInt("AlturaCenario", altCenario);

				Application.LoadLevel("editorCenario");
				/*
				 * Comecar neste ponto a comunicacao para abrir o novo cenario.
				 * A pergunta eh: Como informar para o proximo LEVEL esses dados?
				 */
			}
		}
	}
}


