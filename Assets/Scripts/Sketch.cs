using UnityEngine;
using System.Collections;

public class Sketch : MonoBehaviour {

	public GameObject spinCube;

	void Start () {

		int totalCubes = 8;
		int totalDistance = 5;
		
		for (int i = 0; i < totalCubes; i++) {
		
			float perc = i / (float)totalCubes;
			
			float x = perc * totalDistance;
			float y = 5.0f;
			float z = 0.0f;
			
			var cube = (GameObject)Instantiate (spinCube, new Vector3 (x,y,z), Quaternion.identity);

			// Gradually small
			cube.GetComponent<CubeScript> ().SetSize (1.0f - perc);

			// Small cube early, large cube is slow
			cube.GetComponent<CubeScript> ().rotateSpeed = perc;
		}

	}
	

	void Update () {
	
	}
}
