using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeMainMenuBGColor : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		ChangeSettingsTextColorMainMenu();
	}

	// Update is called once per frame
	void Update()
	{

	}

	//This method changes the background color behind the text "Settings" for different seasons
	void ChangeSettingsTextColorMainMenu()
	{
		ChangeColorSeasonally a = gameObject.AddComponent<ChangeColorSeasonally>();
		int season = a.getSeason();

		RawImage mainMenuBGImage = GameObject.Find("MAINMENUBG").GetComponent<RawImage>();
		Color mainMenuBGColor = mainMenuBGImage.color;

		//Spring
		Color springBGColor = new Color32(152, 191, 173, 255);

		//Summer
		Color summerBGColor = new Color32(124, 173, 62, 255);

		//Fall
		Color fallBGColor = new Color32(237, 134, 31, 255);

		//Winter
		Color winterBGColor = new Color32(131, 43, 62, 255);

		//For different seasons
		switch (season)
		{
			case 1:
				mainMenuBGColor = springBGColor;
				mainMenuBGImage.color = mainMenuBGColor;
				break;
			case 2:
				mainMenuBGColor = summerBGColor;
				mainMenuBGImage.color = mainMenuBGColor;
				break;
			case 3:
				mainMenuBGColor = fallBGColor;
				mainMenuBGImage.color = mainMenuBGColor;
				break;
			case 4:
				mainMenuBGColor = winterBGColor;
				mainMenuBGImage.color = mainMenuBGColor;
				break;
			default:
				Console.WriteLine("Error in Season");
				break;
		}
	}
}
