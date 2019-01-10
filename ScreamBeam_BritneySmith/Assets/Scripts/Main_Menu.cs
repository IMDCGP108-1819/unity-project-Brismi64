using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour 
{

	// play button changes the scene to the game on click
	public void Play()
	{
		SceneManager.LoadScene("Level_1");
	}

	// quit button exits the game on click
	public void Quit()
	{
		Debug.Log("Quit Successful");
		Application.Quit();
	}
	
}
