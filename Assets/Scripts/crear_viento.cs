using UnityEngine;
using System.Collections;

public class crear_viento : MonoBehaviour {
	// Use this for initialization 
	Vector3 temp; 
	public GameObject viento ; 
	void Start () { 
		temp.z = 10; 
		temp.x=0;
		temp.y=5;
		StartCoroutine(espera());
	
	}
	// Update is called once per frame 
	void Update () { 
	

	

	}
	IEnumerator espera() {
		while (true) {
						yield return new WaitForSeconds (5);
						Instantiate (viento, temp, Quaternion.identity); 
				}
	}
} 
