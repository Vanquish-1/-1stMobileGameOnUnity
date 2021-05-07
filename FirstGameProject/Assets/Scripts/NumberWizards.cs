using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
    int max = 1000;
    int min = 1;
	int guess = 500;
	
	void Start () {
		startGame ();
	}
	
	void startGame () {
		max = max + 1;
		print ("==========================================");
		print ("Pick a number in ur head but don't tell me ");  
	    print ("The Highest Number You Can Pick Is"    + max);
		print ("The Lowest Number you can pick is"   +min);
		print ("Is the number higher or lower than" +guess);
		print ("up arrow for higher, down for lower, return for equal");
	}

   
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))	{
			//  print ("Up Arrow pressed");
			NextGuess ();
			print ("Higher or lower than" + guess);
		} else if (Input.GetKeyDown(KeyCode.DownArrow))	{
			// print ("Down Arrow Pressed");
		    NextGuess ();
			print ("Higher or lower than" + guess);
		} else if (Input.GetKeyDown(KeyCode.Return))	{
			print ("I won");
		}
	}
	void NextGuess () {
		max = guess;
		guess = (min + max)/2;
		print ("Higher or lower than"  +guess);
		print ("up arrow for higher, down for lower, return for equal");
	}
}	
	
