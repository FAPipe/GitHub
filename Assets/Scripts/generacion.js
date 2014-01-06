#pragma strict

var objetoAInstanciar:GameObject;
var numeroDeInstancias:int; 
var velocidadDeGeneracion:int; 
private var rot:Quaternion = Quaternion.identity; 
private var nInstancias:int = 0; 
private var tiempoDeGeneracion : float; 
function Update () { if((nInstancias <= numeroDeInstancias) && (Time.time > tiempoDeGeneracion)) { 
	nInstancias += 1; tiempoDeGeneracion = Time.time + velocidadDeGeneracion; 
	var objeto:GameObject = Instantiate(objetoAInstanciar,gameObject.transform.position,rot); 
} 
}