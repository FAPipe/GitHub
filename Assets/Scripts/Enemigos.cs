using UnityEngine;
using System.Collections;

public class Enemigos : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	int velocidadEnemigo = 5;
	// Update is called once per frame
	void Update () {
		//Mover enemigos en el eje z, osea, que aparezcan estos desde el fondo de la pantalla hacia la nave.
		transform.Translate (0, 0, -velocidadEnemigo * Time.deltaTime);

		//Si los enemigos salen de la pantalla, estos vuelven a aparecer, desde el fondo.
		if(transform.position.z <= -7){
			Vector3 temp = transform.position; 
			temp.z = 10;
			temp.x=Random.Range(-8,8);
			temp.y=Random.Range(-4,4);
			transform.position = temp;
		}
	}
}

