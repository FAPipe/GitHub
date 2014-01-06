using UnityEngine;
using System.Collections;

public class trigger_lluvia : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		print ("entro al trigger");
	}

	
	void OnTriggerStay (Collider other){
		print ("esta dentro del trigger");
	}
	void OnTriggerExit (Collider other){
		print ("sali del trigger");
	}
}
