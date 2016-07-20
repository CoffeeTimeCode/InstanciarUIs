using UnityEngine;
using System.Collections;

public class InstanciarUI : MonoBehaviour {

	public GameObject _ui;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Instanciar();
		}
	}

	public void Instanciar()
	{
		GameObject _objeto = Instantiate (_ui,Input.mousePosition,_ui.transform.rotation) as GameObject;
		_objeto.transform.SetParent (this.transform);
	}
}
