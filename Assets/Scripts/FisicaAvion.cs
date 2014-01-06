using UnityEngine;
using System.Collections;

public class FisicaAvion : MonoBehaviour {

	// variables publicas de las condiciones climaticas
	public bool viento_este;
	public bool viento_oeste;
	public bool lluvia_estado;
	public GameObject avion;
	int velocidad_elementos;
	void Start () {
		//velocidad inicial del movimeinto de los elementos es 3, comienza el juego sin ningun elemento en el campo
		velocidad_elementos = 3;
		viento_este=false;
		viento_oeste=false;
		lluvia_estado=false;

	
	}
	
	// Se pregunta que condiciones se encuentran activadas y se mueve el objeto en una direccion dependiente de estos
	void Update () {	
		if(viento_este){			
			avion.transform.Translate (Vector3.right * Time.deltaTime * velocidad_elementos);
		}	
		if(viento_oeste){			
			avion.transform.Translate (Vector3.left * Time.deltaTime * velocidad_elementos);
		}	
		if(lluvia_estado){			
			avion.transform.Translate (Vector3.down * Time.deltaTime * velocidad_elementos);
		}		
		avion.transform.Translate (Vector3.down * Time.deltaTime * 1);
	}
}