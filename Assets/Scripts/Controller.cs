using UnityEngine;
using System.Collections;
//objeto que se encarga de controlar los movimientos y el juego
public class Controller : MonoBehaviour {
	public float velocidadObjetos;
	public float momentumAvion;
	public int nivel;
	public int maxObjetos;
	public int cantObjetos;
	// Use this for initialization
	void Start () {
		velocidadObjetos=1f;
		momentumAvion=0f;
		nivel =1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
