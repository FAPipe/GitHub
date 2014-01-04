using UnityEngine;
using System.Collections;
/*Script que maneja el accelerometro para el avion de papel:
 * para cambiar los ejes de movimiento se debe modificar la variable dir, colocando en cada celda el eje que desee
 * ejemplo: (ejey,ejex,ejez) significa que eje x del juego corresponde el eje y del accelerometro, eje y del juego al 
 * eje x del accelerometro, etc.
 * */
public class accelerometro : MonoBehaviour {
	float velocidad=10f;
	float xmin= -10f;
	float xmax=10f;
	float ymin=-10f;
	float ymax=10f;
	float zmin=-10f;
	float zmax=10f;
	float filtro=5f;

	Vector3 ac;
	Vector3 dir;
	Vector3 pos;
	// Use this for initialization
	void Start () {
		ac = Input.acceleration;
	}
	
	// Update is called once per frame
	void Update () {
		ac = Vector3.Lerp (ac, Input.acceleration, filtro * Time.deltaTime);
		dir =new Vector3 (ac.x,-ac.y, 0);
		if (dir.sqrMagnitude > 1)
						dir.Normalize ();
		transform.Translate (dir * velocidad * Time.deltaTime);
		pos = transform.position;
		pos.x = Mathf.Clamp (pos.x, xmin, xmax);
		pos.y =Mathf.Clamp(pos.y,ymin,ymax);
		transform.position = pos;

	}
}
