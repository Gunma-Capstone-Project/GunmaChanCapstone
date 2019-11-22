using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ChangeMainMenuColors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeColorMainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeColorMainMenu()
    {
        int size = 4;
        Button[] settingsMenuButtons = new Button[size];
        ColorBlock[] settingsMenuColors = new ColorBlock[size];

        settingsMenuButtons[0] = GameObject.Find("PLAYBUTTON").GetComponent<Button>();
        settingsMenuColors[0] = settingsMenuButtons[0].colors;

        settingsMenuButtons[1] = GameObject.Find("FLASHCARDSBUTTON").GetComponent<Button>();
        settingsMenuColors[1] = settingsMenuButtons[1].colors;

        settingsMenuButtons[2] = GameObject.Find("VIDEOTUTORIALSBUTTON").GetComponent<Button>();
        settingsMenuColors[2] = settingsMenuButtons[2].colors;

        settingsMenuButtons[3] = GameObject.Find("SETTINGSBUTTON").GetComponent<Button>();
        settingsMenuColors[3] = settingsMenuButtons[3].colors;

        //Spring Colors
        Color springColorHighLightAndSelected = new Color32(255, 196, 178, 255);
        Color springColorPressed = new Color32(216, 57, 87, 255);

        //Summer Colors
        Color summerColorHighlightAndSelected = new Color32(207, 223, 218, 255);
        Color summerColorPressed = new Color32(35, 100, 119, 255);

        //Fall Colors
        Color fallColorHighlightAndSelected = new Color32(217, 77, 44, 255);
        Color fallColorPressed = new Color32(149, 103, 17, 255);

        //Winter Colors
        Color winterColorHighlightAndSelected = new Color32(234, 11, 63, 255);
        Color winterColorPressed = new Color32(104, 108, 88, 255);

        ChangeColorSeasonally a = gameObject.AddComponent<ChangeColorSeasonally>();
        int season = a.getSeason();

        switch (season)
        {
            case 1:
                for (int i = 0; i < size; i++)
                {
                    settingsMenuColors[i].highlightedColor = springColorHighLightAndSelected;
                    settingsMenuColors[i].pressedColor = springColorPressed;
                    settingsMenuColors[i].selectedColor = springColorHighLightAndSelected;
                    settingsMenuButtons[i].colors = settingsMenuColors[i];
                }
                break;
            case 2:
                for (int i = 0; i < size; i++)
                {
                    settingsMenuColors[i].highlightedColor = summerColorHighlightAndSelected;
                    settingsMenuColors[i].pressedColor = summerColorPressed;
                    settingsMenuColors[i].selectedColor = summerColorHighlightAndSelected;
                    settingsMenuButtons[i].colors = settingsMenuColors[i];
                }
                break;
            case 3:
                for (int i = 0; i < size; i++)
                {
                    settingsMenuColors[i].highlightedColor = fallColorHighlightAndSelected;
                    settingsMenuColors[i].pressedColor = fallColorPressed;
                    settingsMenuColors[i].selectedColor = fallColorHighlightAndSelected;
                    settingsMenuButtons[i].colors = settingsMenuColors[i];
                }
                break;
            case 4:
                for (int i = 0; i < size; i++)
                {
                    settingsMenuColors[i].highlightedColor = winterColorHighlightAndSelected;
                    settingsMenuColors[i].pressedColor = winterColorPressed;
                    settingsMenuColors[i].selectedColor = winterColorHighlightAndSelected;
                    settingsMenuButtons[i].colors = settingsMenuColors[i];
                }
                break;
        }
    }
}
