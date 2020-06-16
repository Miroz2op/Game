using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;

    public static int numberOfCoins;
    public Text coinsText;


	public Text scoreText;
	public float scoreAmount;
	public float pointInc;

	//public Text coinsSave;

	

	

	void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        isGameStarted = false;
        numberOfCoins = 0;

		scoreAmount = 0f;
		pointInc = 5f;
	}

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {

			int savedScore = PlayerPrefs.GetInt("HighScore");
			if ((int)scoreAmount > savedScore)
			{
				PlayerPrefs.SetInt("HighScore", (int)scoreAmount);
			}

			int savedCoin = PlayerPrefs.GetInt("HighCoin");
			if ((int)numberOfCoins > savedCoin)
			{
				PlayerPrefs.SetInt("HighCoin", (int)numberOfCoins);
			}


			gameOverPanel.SetActive(true);
            Time.timeScale = 0;


		}

        coinsText.text = "Coins: " + numberOfCoins;

	

		if (SwipeManager.tap  && !isGameStarted)
        {
            isGameStarted = true;
            Destroy(startingText);
			
		}

        if (isGameStarted)
		{
			scoreText.text = (int)scoreAmount + " m.";
			scoreAmount += pointInc * Time.deltaTime;

			
		}

        //if (gameOver)
		//{
		//	coinsSave.text = coinsText.text;
		//}
	}

}
