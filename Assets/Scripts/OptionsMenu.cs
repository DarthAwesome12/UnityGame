using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
	int i = 0;
	public static bool easterEgg = false;
	public GameObject mainMenu;
	public Button backButton;
	public  GameObject aaQualityObj;
	public GameObject aaTypeObj;
	private TMP_Dropdown aaQuality;
	private TMP_Dropdown aaType;
	
 
   public void Back()
	{
		gameObject.SetActive(false);
		mainMenu.SetActive(true);
	}

	

	public void ToggleFullscreen()
	{
		Screen.fullScreen = !Screen.fullScreen;
	}

	public void VolumeButton() //George's unfunny easteregg
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

	public void AAType(int choice) {
		aaQuality = aaQualityObj.GetComponent<TMP_Dropdown>(); 
		PlayerPrefs.SetInt("AAType", choice);
		
		if (choice == 0) //if AA is off, there should be no AA-Quality options
		{
			aaQuality.ClearOptions();
			aaQuality.options.Add(new TMP_Dropdown.OptionData("None"));
			aaQuality.onValueChanged.RemoveAllListeners();
			aaQuality.value = 0;
			aaQuality.onValueChanged.AddListener(AAQuality);

		}
		else if (aaQuality.options.Count == 4 || aaQuality.options.Count == 1)
		{

			aaQuality.ClearOptions(); //removes all options

			List<string> optionList = new List<string>() {"Low", "Medium", "High" }; //array of all options
			aaQuality.AddOptions(optionList); //sets options to array values
			PlayerPrefs.SetInt("AAQuality", aaQuality.value);
		}
		aaQuality.RefreshShownValue();

	}

	public void AAQuality(int choice) {
		aaQuality = aaQualityObj.GetComponent<TMP_Dropdown>(); //gets dropdown object
		if (aaQuality.options.Count == 3) {
			PlayerPrefs.SetInt("AAQuality", choice);
			
		
		}
	
	}

	private void OnEnable()
	{
		backButton.Select();
	}

	private void Awake()
	{
		aaQuality = aaQualityObj.GetComponent<TMP_Dropdown>();
		aaType = aaTypeObj.GetComponent<TMP_Dropdown>();

		aaQuality.onValueChanged.RemoveAllListeners();
		aaType.onValueChanged.RemoveAllListeners();


		aaQuality.value = PlayerPrefs.GetInt("AAQuality", 0);


		aaType.value = PlayerPrefs.GetInt("AAType", 0);

		Debug.Log(aaType.value);

		if (aaType.value > 0)
		{
			aaQuality.ClearOptions(); //removes all options

			List<string> optionList = new List<string>() { "Low", "Medium", "High" }; //array of all options
			aaQuality.AddOptions(optionList); //sets options to array values
		}

		else {

			aaQuality.ClearOptions();
			aaQuality.options.Add(new TMP_Dropdown.OptionData("None"));
			aaQuality.onValueChanged.RemoveAllListeners();
			aaQuality.value = 0;
			aaQuality.onValueChanged.AddListener(AAQuality);




		}


		aaQuality.value = PlayerPrefs.GetInt("AAQuality", 0);


		aaType.value = PlayerPrefs.GetInt("AAType", 0);



		aaQuality.onValueChanged.AddListener(AAQuality);
		aaType.onValueChanged.AddListener(AAType);



		aaQuality.RefreshShownValue();
		aaType.RefreshShownValue();
		
	}

}
