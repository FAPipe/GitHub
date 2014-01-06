using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {
	public GameObject avion;
	public int velocidad;
	// Use this for initialization
	void Start () {
		// velocidad de movimiento
		velocidad = 3;

	
	
	}
	
	// Update is called once per frame
	void Update () {
		//pregunta si se encuentra  alguna de las teclas presionadas y se realiza un movimiento dependiente de estas
	
		if (Input.GetKey(KeyCode.D)) {

			avion.transform.Translate(Vector3.right * Time.deltaTime*velocidad );

		}
		if (Input.GetKey(KeyCode.S)) {
			
			avion.transform.Translate(Vector3.down * Time.deltaTime*velocidad);
		}
		if (Input.GetKey(KeyCode.A)) {
			
			avion.transform.Translate(Vector3.left * Time.deltaTime*velocidad);		
		}
		if (Input.GetKey(KeyCode.W)) {
			
			avion.transform.Translate(Vector3.up * Time.deltaTime*velocidad);
		}
	
	}
}
