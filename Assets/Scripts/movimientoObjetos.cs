using UnityEngine;
using System.Collections;

public class movimientoObjetos : MonoBehaviour {

	float velocidad;
	Controller script;
	int asd;


	// Use this for initialization
	void Start () {

		script = GameObject.Find ("Controller").GetComponent<Controller> ();


	}
	IEnumerator espera(){
		yield return new WaitForSeconds(1);
	}
	
	// Update is called once per frame
	void Update () {
		script = GameObject.Find ("Controller").GetComponent<Controller> ();
		transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z
		                                  -script.velocidadObjetos);
		if (transform.position.z < -5f && asd == 0) {
			script.resta_cant();
			asd=1;
			//espera ();
			//Destroy(this.gameObject,0.5f);
		}
	
	}
}
 	