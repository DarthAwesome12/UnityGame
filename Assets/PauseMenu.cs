using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public GameObject buttons;
    public void Exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
		Time.timeScale = 1f;
	}

	private void Update()
	{
		if (Input.GetButtonDown("Pause"))
		{
			Debug.Log("Escape Menu");
			buttons.SetActive(!buttons.activeSelf);
		}
	}
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1f;
	}
}
