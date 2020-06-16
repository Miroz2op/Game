using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }

	public void GoToCreditsMenu()
	{
		SceneManager.LoadScene("CreditsMenu");
	}

	public void GoToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void QuitGame()
    {
        Application.Quit();
    }
}




	


