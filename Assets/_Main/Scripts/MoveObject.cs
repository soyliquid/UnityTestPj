using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

	public Vector3 MoveVector;
	public Vector3 RotateVector;
	public float Speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(MoveVector * Time.deltaTime * Speed);
		transform.Rotate(RotateVector * Time.deltaTime * Speed);
	}
}
