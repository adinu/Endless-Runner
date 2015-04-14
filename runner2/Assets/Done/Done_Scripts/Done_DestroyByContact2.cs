using UnityEngine;
using System.Collections;

public class Done_DestroyByContact2 : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	public int healthCount = 4;
	private Done_GameController gameController;
	public enum_Side side;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <Done_GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("other.name" + other.name);


		if (explosion != null)
		{
			Instantiate(explosion, transform.position, transform.rotation);
		}

		if (other.tag == "Boundary")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);

			//gameController.GameOver();
			healthCount--;
			Debug.Log("boundry hit");
			Destroy (gameObject);
		}

//		if (other.tag == "Boundary_R") 
//		{
//						
//			if(side == enum_Side.side_right) {		
//			   gameController.AddScore(scoreValue);
//				gameController.AddPigCount();
//			   Destroy (this);
//			} else if(side == enum_Side.side_left) {		
//				gameController.AddScore(-scoreValue);
//				healthCount--;
//				Destroy (this);
//			}
//
//		}
		if (other.tag == "gate") {
						
			Debug.Log("gate hit");
				gameController.AddScore (scoreValue);
				gameController.AddSheepCount ();
			Destroy (gameObject);

		}
//		
//		if (other.tag == "Boundary_L") 
//		{
//			
//				if(side == enum_Side.side_left) { 		
//			gameController.AddScore(scoreValue);
//				gameController.AddSheepCount();
//				Destroy (this);
//
//			} else if(side == enum_Side.side_right) {		
//				gameController.AddScore(-scoreValue);
//				healthCount--;
//				Destroy (this);
//			}
//		}

		if (other.tag == "bomb") 
		{
			gameController.AddScore(-scoreValue);
			healthCount--;
			Destroy (gameObject);
		}

	}
}