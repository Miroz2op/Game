﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class High : MonoBehaviour
{
	Text highscore;

	void OnEnable()
	{
		highscore = GetComponent<Text>();
		highscore.text = "Highscore: " + PlayerPrefs.GetInt("HighScore").ToString() + " m.";
	}
}
