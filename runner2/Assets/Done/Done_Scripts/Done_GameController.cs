using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Done_GameController : MonoBehaviour
{
	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	public Text scoreText;
	public Text restartText;
	public Text gameOverText;
	public Text pigCounter;
	public Text  sheepCounter;
	
	private bool gameOver;
	private bool restart;
	private int score;
	private int[] numSign;
	private int pigCount=0;
	private int sheepCount=0;
	
	void Start ()
	{
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
		numSign = new int[]{1,-1};
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
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
				Vector3 spawnPosition;
				if(hazard.tag=="bomb"){
					//generate wall at right or left of screen
					 spawnPosition = new Vector3 ((numSign[Random.Range(0,numSign.Length)] * (spawnValues.x ))
					                                                  , spawnValues.y, spawnValues.z);	
				}
				else {
				 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				}
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
			
			if (gameOver)
			{
				restartText.text = "Press 'R' for Restart";
				restart = true;
				break;
			}
		}
	}
	
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
		scoreText.text =  ""+score;
		pigCounter.text =  ""+pigCount;
		sheepCounter.text =  ""+sheepCount;
	}
	
	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;
	}

	public void AddPigCount ()
	{
		pigCount += 1;
		UpdateScore ();
	}

	public void AddSheepCount ()
	{
		sheepCount += 1;
		UpdateScore ();
	}
}