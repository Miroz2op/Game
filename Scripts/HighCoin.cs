using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HighCoin : MonoBehaviour
{
	Text highcoin;

	void OnEnable()
	{
		highcoin = GetComponent<Text>();
		highcoin.text = "Highcoin: " + PlayerPrefs.GetInt("HighCoin").ToString();
	}
}
