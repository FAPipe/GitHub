using UnityEngine;
using System.Collections;

public class Obj_viento : MonoBehaviour {

	// Use this for initialization
	public int tipoViento;


	void Start () {
		// 1 este , 2 oeste
		tipoViento=Random.Range(1,3);
		print(tipoViento);
	
		
	}
	
	int velocidadEnemigo = 5;
	// Update is called once per frame
	void Update () {	
		//Mover enemigos en el eje z, osea, que aparezcan estos desde el fondo de la pantalla hacia la nave.
		transform.Translate (0, 0, -velocidadEnemigo * Time.deltaTime);
		
		//Si los enemigos salen de la pantalla, estos vuelven a aparecer, desde el fondo.
		if(transform.position.z <= -12){

				
			Destroy(gameObject);

		}
	}
}