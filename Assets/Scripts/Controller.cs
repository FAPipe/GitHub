using UnityEngine;
using System.Collections;
//objeto que se encarga de controlar los movimientos y el juego
public class Controller : MonoBehaviour {
	public float velocidadObjetos;
	public float momentumAvion;
	public int nivel;
	public int maxObjetos;
	public int cantObjetos;
	Vector3 temp;

	public GameObject enemigo;
	// Use this for initialization
	void Start () {
		velocidadObjetos=0.05f;
		momentumAvion=0f;
		nivel =1;
		maxObjetos = 5;
		cantObjetos = 0;
	}
	
	// Update is called once per frame
	void Update () {
			if (cantObjetos < maxObjetos) {
					temp.z = 30; 
					temp.x = Random.Range (-8, 8); 
					temp.y = Random.Range (-4, 4); 
					Instantiate (enemigo, temp, Quaternion.identity);
					cantObjetos++;
			}
	}
	public void resta_cant(){
		cantObjetos--;
	}
}
