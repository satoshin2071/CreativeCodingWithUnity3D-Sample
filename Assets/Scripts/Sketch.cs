using UnityEngine;
using System.Collections;

public class Sketch : MonoBehaviour {

	public GameObject spinCube;

	void Start () {

		int totalCubes = 8;
		float totalDistance = 2.9f;

		for (int i = 0; i < totalCubes; i++) {
			
			float perc = i / (float)totalCubes;

			float sin = Mathf.Sin(perc * Mathf.PI/2);
			
			float x = 1.8f + sin * totalDistance;
			float y = 5.0f;
			float z = 0.0f;
			
			var cube = (GameObject)Instantiate (spinCube, new Vector3 (x,y,z), Quaternion.identity);
			
			// Gradually small
			cube.GetComponent<CubeScript> ().SetSize ((1.0f - perc) * .5f );
			
			// Small cube early, large cube is slow
			cube.GetComponent<CubeScript> ().rotateSpeed = .2f + perc*4.0f;
		}
		
	}
	

	void Update () {
	
	}
}
