using UnityEngine;
using System.Collections;
using System.Xml;

public class ControleMenuCriacaoMapas : MonoBehaviour {

	public TextAsset arquivoXMLMenus;
	public TextAsset arquivoXMLBotoes;

	private XmlDocument xml;

	// Use this for initialization
	void Start () {
		//arquivoXMLMenus = Application.dataPath+"/xmls/menus.xml";
		//arquivoXMLBotoes = Application.dataPath+"/xmls/botoes.xml";
		CarregarTextos ();

	}

	void CarregarTextos() {
		xml = new XmlDocument ();
		CarregarMenus (xml);
		xml = new XmlDocument ();
		CarregarBotoes (xml);

	}

	void CarregarMenus(XmlDocument xml) {
		xml.LoadXml (arquivoXMLMenus.text);
		XmlNodeList menus = xml.GetElementsByTagName("menus");
		foreach (XmlNode grupos in menus) {
			XmlNodeList listaGrupos = grupos.ChildNodes;
			foreach(XmlNode grupo in listaGrupos) {
				if(grupo.Attributes["tipo"] != null) {
					if(gameObject.CompareTag(grupo.Attributes["tipo"].Value)) {
						XmlNodeList listaMenus = grupo.ChildNodes;
						foreach( XmlNode menu in listaMenus) {
							string id = "";
							string texto = "";
							int tamanhoFonte = 0;
							XmlNodeList itens = menu.ChildNodes;
							foreach (XmlNode item in itens) {
								// Id
								if(item.Name.Equals("id")) {
									id = item.InnerText;
								}
								// Titulo
								if(item.Name.Equals("texto")) {
									texto = item.InnerText;
									if(item.Attributes["tamanhoFonte"] != null) {
										tamanhoFonte =  int.Parse(item.Attributes["tamanhoFonte"].Value);
									}
								}	
							}
							GameObject obj = GameObject.FindGameObjectWithTag(id);
							obj.GetComponent<TextMesh>().text = texto;
							obj.GetComponent<TextMesh>().fontSize = tamanhoFonte;
						}
					}
				}
			}
		}
	}

	void CarregarBotoes(XmlDocument xml) {
		xml.LoadXml (arquivoXMLBotoes.text);
		XmlNodeList botoes = xml.GetElementsByTagName("botoes");
		foreach (XmlNode grupos in botoes) {
			XmlNodeList listaGrupos = grupos.ChildNodes;
			foreach (XmlNode grupo in listaGrupos) {
				if(grupo.Attributes["tipo"] != null) {
					if(gameObject.CompareTag(grupo.Attributes["tipo"].Value)) {
						XmlNodeList listaBotoes = grupo.ChildNodes;
						foreach( XmlNode botao in listaBotoes) {
							string id = "";
							string texto = "";
							int tamanhoFonte = 0;
							XmlNodeList itens = botao.ChildNodes;
							foreach (XmlNode item in itens) {

								// Id
								if(item.Name.Equals("id")) {
									
									id = item.InnerText;
								}
								// Titulo
								if(item.Name.Equals("texto")) {
									texto = item.InnerText;
									if(item.Attributes["tamanhoFonte"] != null)
										tamanhoFonte =  int.Parse(item.Attributes["tamanhoFonte"].Value);
								}
							}
							GameObject obj = GameObject.FindGameObjectWithTag(id);
							obj.GetComponentInChildren<TextMesh>().text = texto;
							obj.GetComponentInChildren<TextMesh>().fontSize = tamanhoFonte;
						}
					}
				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
