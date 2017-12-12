using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour {

	public static int score;
	public int currentScore;
	public Text winText;
	public int winScore;
	public Text text;

	void Awake(){
		Time.timeScale = 1;
	}
	// Use this for initialization
	void Start () {
		winText.GetComponent<Text>().enabled = false;
		text = GetComponent<Text>();
		// currentScore.text = score.ToString();
		   score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0){
			score = 0;
		}
		currentScore = score;
		text.text = currentScore.ToString();
		//if the player wins display win text
		if(score >= winScore)
		{
			// print("win score reached dummy " + score);
			winText.GetComponent<Text>().enabled = true; 
			Time.timeScale = 0;
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}
	}

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
		// Debug.Log(score);
	}

	public static void MinusPoints(int pointsToMinus){
		score -= pointsToMinus;
		// Debug.Log(score);
	}
	
	public void Reset(){
		score = 0;
	}

}

