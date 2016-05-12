using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	public float rotateSpeed = 1.0f;
	public Vector3 spinVelocity = Vector3.zero;
	Vector3 spinAxis = new Vector3 (0,1,0);
	
	void Start () {
		spinVelocity = new Vector3 (Random.value, Random.value, Random.value);
		spinAxis = Vector3.up;
		spinAxis.x = (Random.value - Random.value) * .1f; //little bit noise spinAxis.x
	}
	
	void Update () {
		this.transform.Rotate (spinVelocity);
		this.transform.RotateAround (Vector3.zero, spinAxis, rotateSpeed);
	}
	
	public void SetSize(float size)
	{
		this.transform.localScale = new Vector3 (size, size, size);
	}
}
