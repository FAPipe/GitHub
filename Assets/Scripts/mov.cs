using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {
	public GameObject avion;
	int dere = 0;
	// Use this for initialization
	void Start () {

	
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.D)) {
			dere= dere-1;
			avion.transform.Translate(Vector3.right * Time.deltaTime*6 );

		}
		if (Input.GetKey(KeyCode.S)) {
			
			avion.transform.Translate(Vector3.down * Time.deltaTime*6);
		}
		if (Input.GetKey(KeyCode.A)) {
			
			avion.transform.Translate(Vector3.left * Time.deltaTime*6);		
		}
		if (Input.GetKey(KeyCode.W)) {
			
			avion.transform.Translate(Vector3.up * Time.deltaTime*6);
		}
	
	}
}
