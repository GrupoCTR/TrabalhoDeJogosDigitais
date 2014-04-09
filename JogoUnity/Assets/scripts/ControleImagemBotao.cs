using UnityEngine;
using System.Collections;

public class ControleImagemBotao : MonoBehaviour {

	public Sprite normal;
	public Sprite sobre;
	public Sprite pressionado;

	private SpriteRenderer renderizadorSprite;
	// Use this for initialization
	void Start () {
		renderizadorSprite = (SpriteRenderer) gameObject.GetComponent(typeof(SpriteRenderer));
		//renderizadorSprite = (gameObject.GetComponent(SpriteRenderer));
		renderizadorSprite.sprite = normal;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter() {
		renderizadorSprite.sprite = sobre;
	}

	void OnMouseExit() {
		renderizadorSprite.sprite = normal;
	}

	void OnMouseDown() {
		renderizadorSprite.sprite = pressionado;
	}

	void OnMouseUpAsButton() {
		renderizadorSprite.sprite = sobre;
	}


}
