﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float timeRemaining = 100f;
	public Scrollbar sb; 
	public float timeToDecrease;
	private Done_GameController gameController;


	void Start () {
		sb.size = 1;
		InvokeRepeating ("decreaseTimeRemaining", 1.0f, 0.06f);
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
		gameController = gameControllerObject.GetComponent <Done_GameController>();
	}


	void Update()
	{
//		if (timeRemaining == 0 )
//		{
//			gameController.GameOver();
//		}

		sb.size = (float) timeRemaining / 100;

		
	}

	void decreaseTimeRemaining()
	{

		if (timeRemaining == 0) {
			gameController.GameOver ();
		} else {
			timeRemaining -= timeToDecrease;
			Debug.Log ("timeRemaining " + timeRemaining);
		}
	}

	public void increaseTimeRemaining(float timeToAdd)
	{
		timeRemaining += timeToAdd;
	}
	// Update is called once per frame
//	void Update () {
//		
//	}
//
//	public void Awake(){
//		TimerEvents.onAddTime += this.AddTime ();
//		TimerEvents.onSubstractTime += this.SubTime ();
//
//	}


}
