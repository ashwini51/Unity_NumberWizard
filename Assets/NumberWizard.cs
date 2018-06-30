using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	public Text text;
	public int maxGuessAllowed = 10;
	void Start () {
		StartGame();
	}
	void StartGame () {
		max = 1000;
		min = 1;
		NextGuess ();
	}
	// Update is called once per frame
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	void NextGuess () {
		guess = Random.Range(min,max+1);
		text.text = guess.ToString ();
		maxGuessAllowed = maxGuessAllowed - 1;
		if (maxGuessAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
