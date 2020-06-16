using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseButton : MonoBehaviour
{
	public GameObject PauseScreen;

	bool isPaused;

    void Start()
	{
		isPaused = false;
	}

    void Update()
	{
		if (isPaused)
		
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
		
	}

    public void pauseGame()
	{
		isPaused = true;
		PauseScreen.SetActive(true);
	}

    public void ResumeGame()
	{
		isPaused = false;
		PauseScreen.SetActive(false);
	}
	

}
