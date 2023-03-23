using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	public GameObject optionsMenu;
	public Button startButton;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

	public void QuitGame()
	{
		Application.Quit();		
	}
	public void OptionsScreen()
	{
		gameObject.SetActive(false);
		optionsMenu.SetActive(true);

	}

	private void OnEnable()
	{
		startButton.Select();
	}
}
