using UnityEngine;
using System.Collections;

public class movimientoObjetos : MonoBehaviour {

	float velocidad;
	Controller script;



	// Use this for initialization
	void Start () {

		script = GameObject.Find ("Controller").GetComponent<Controller> ();


	}

	// Update is called once per frame
	void Update () {
		script = GameObject.Find ("Controller").GetComponent<Controller> ();
		transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z
		                                  -script.velocidadObjetos);
		if (transform.position.z < -3f ) {
			if(gameObject.tag=="enemigo"){
				script.resta_cant();
				Destroy(this.gameObject);
			}
			else if(gameObject.tag=="roca 1"||gameObject.tag=="roca 2"||gameObject.tag=="roca 3"||gameObject.tag=="roca 4"){
				script.resta_roca();
				Destroy (this.gameObject);
			}
						

		}
	
	}
}
 	