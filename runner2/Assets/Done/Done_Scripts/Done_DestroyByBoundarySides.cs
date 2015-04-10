using UnityEngine;
using System.Collections;

public enum enum_Side{
	side_left = 0,
	side_right = 1
};

public class Done_DestroyByBoundarySides : MonoBehaviour
{
	public int type; //0-Left  1-Right
	public enum_Side side;

	void OnTriggerEnter (Collider other) 
	{
		//The correct animal hit the right side
		if (side == enum_Side.side_right && type == 1) {	
			Destroy (other.gameObject);
			//TODO: increase score
			
		} else if (side == enum_Side.side_left && type == 0) {		
			Destroy (other.gameObject);
		} else {
			//TODO: Decrease lives
			Destroy (other.gameObject);
		}
      }
	
}