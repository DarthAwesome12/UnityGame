using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
	int i = 0;
	public static bool easterEgg = false;
	public GameObject mainMenu;
	public Button backButton;
   public void Back()
	{
		gameObject.SetActive(false);
		mainMenu.SetActive(true);
	}

	public void ToggleFullscreen()
	{
		Screen.fullScreen = !Screen.fullScreen;
	}

	public void VolumeButton()
	{
		i++;
		if (i == 15)
		{
			easterEgg = !easterEgg;
			Debug.Log("Easter Egg Activated");
		}

		if (i == 30) { 
		
			easterEgg = !easterEgg;
			Debug.Log("Easter Egg Disabled");
			i = 0;
		
		}
		
	}

	private void OnEnable()
	{
		backButton.Select();
	}

}
