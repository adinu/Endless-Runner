using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ScrollParallax : MonoBehaviour 
{
	public Camera camera;
	
	public float xParallax = 0.4f;
	public float yParallax = 0.4f;
	
	void LateUpdate () 
	{
		Vector3 tempPos = transform.position;
		
		tempPos.x = camera.transform.position.x * xParallax;
		tempPos.y = camera.transform.position.y * yParallax;
		
		transform.position = tempPos;
	}
}