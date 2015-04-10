using UnityEngine;
using System.Collections;

public class TapToMove : MonoBehaviour {


	void OnMouseDown (){
		Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 touchPos = new Vector2(wp.x, wp.y);
		Debug.Log("touchPos" + touchPos);
		Rigidbody rb = GetComponent<Rigidbody> ();

		if (Input.GetMouseButtonDown(0))
			rb.AddForce (-transform.right * 3000);

//		if (Input.GetMouseButtonDown(0))
//			rb.AddForce (-transform.right * 3000);
//		



	}
}