using UnityEngine;
using System.Collections;
//objeto que se encarga de controlar los movimientos y el juego
public class Controller : MonoBehaviour {
	public float velocidadObjetos;
	public float momentumAvion;
	public int nivel;
	int maxObjetos;
	int vidas;
	int cantObjetos;
	int cantRocas=4;
	public int puntaje;
	Vector3 temp;
	float pausa;

	public GameObject enemigo;
	public GameObject roca1;
	public GameObject roca2;
	public GameObject roca3;
	public GameObject roca4;

	// Use this for initialization
	void Start () {
		velocidadObjetos=0.05f;
		momentumAvion=0.005f;
		nivel =1;
		maxObjetos = 5;
		cantObjetos = 0;
		vidas = 3;
	}
	int ObjetoAGenerar(){
		return 1;
	}
	IEnumerator espera(int n){
		yield return new WaitForSeconds(n);

	}
	
	// Update is called once per frame
	void Update () {
		if (pausa > 0) {
						pausa-=Time.deltaTime;

				} else {
						if (cantRocas > 0) {
								if (Random.value > 0.8f) {
										Instantiate (roca1, new Vector3 (Random.Range (-7, 7), 0.4f, 30), Quaternion.identity);
										cantRocas--;
										pausa = Random.Range (1f, 3f);

								}
								if (Random.value > 0.5f) {
										Instantiate (roca2, new Vector3 (Random.Range (-6, 6), 0.5f, 30), Quaternion.identity);
										cantRocas--;
										pausa = Random.Range (1f, 3f) ;
								}
								if (Random.value > 0.7f) {
										Instantiate (roca3, new Vector3 (Random.Range (-7, 7), 0.2f, 30), Quaternion.identity);
										cantRocas--;
										pausa = Random.Range (1f, 3f) ;
								}
								if (Random.value > 0.7f) {
										Instantiate (roca4, new Vector3 (Random.Range (-7, 7), 0.1f, 30), Quaternion.identity);
										cantRocas--;
										pausa = Random.Range (1f, 3f) ;
								}

						}
				
						if (cantObjetos < maxObjetos) {//genera un objeto
								temp.z = 30; //distancia a generar el objeto
								temp.x = Random.Range (-7, 7); 
								temp.y = Random.Range (0, 4); 
								Instantiate (enemigo, temp, Quaternion.identity);
								cantObjetos++;
								pausa = Random.Range (1f, 3f) ;
						}
				}
		puntaje=(int)Time.timeSinceLevelLoad;
		maxObjetos = 5 + puntaje / 60;
		velocidadObjetos += puntaje / 500000f;
		if (maxObjetos > 20)
						maxObjetos = 20;
	}
	public void resta_roca(){
		cantRocas++;
	}
	public void resta_cant(){
		cantObjetos--;
	}
}
