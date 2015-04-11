using UnityEngine;
using System.Collections;

public class open_scene_conroller : MonoBehaviour
{
	public GUIText scoreText;
	public GUIText restartText;
	public GUIText gameOverText;
	

	private bool restart;
	
	void Start ()
	{

		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		
	}
	
	void Update ()
	{
		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
	
	void play()
	{
		Application.LoadLevel (1);
	}

	
	
	
	
}