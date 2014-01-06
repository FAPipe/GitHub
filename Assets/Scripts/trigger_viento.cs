using UnityEngine;
using System.Collections;

public class trigger_viento : MonoBehaviour {
	GameObject flecha; 

	void Start (){
		flecha =  GameObject.FindWithTag("indica");;
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name.Equals("Sphere")){

			Obj_viento objviento =gameObject.GetComponent<Obj_viento>();
			if(objviento.tipoViento == 1)
				flecha.transform.eulerAngles= new Vector3(0,90,-90);
			if(objviento.tipoViento == 2)
				flecha.transform.eulerAngles= new Vector3(0,-90,90);

		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.name.Equals("Sphere")){
			flecha.transform.eulerAngles= new Vector3(270,0,0);
		}
	}
}
