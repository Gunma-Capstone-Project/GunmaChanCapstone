using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ColorChangeSounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeColorForToggles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeColorForToggles()
    {
        //Loading On/Off toggles for different seasons from assets
        Sprite onButtonSpring = Resources.Load<Sprite>("Buttons/OnButtonSpring");
        Sprite offButtonSpring = Resources.Load<Sprite>("Buttons/OffButtonSpring");
        Sprite onButtonSummer = Resources.Load<Sprite>("Buttons/OnButtonSummer");
        Sprite offButtonSummer = Resources.Load<Sprite>("Buttons/OffButtonSummer.jpg");
        Sprite onButtonFall = Resources.Load<Sprite>("Buttons/OnButtonFall");
        Sprite offButtonFall = Resources.Load<Sprite>("Buttons/OffButtonFall");
        Sprite onButtonWinter = Resources.Load<Sprite>("Buttons/OnButtonWinter");
        Sprite offButtonWinter = Resources.Load<Sprite>("Buttons/OffButtonWinter");

        //Finding the images that use the toggles
        Image bgMusicOn = GameObject.Find("BGMusicOn").GetComponent<Image>();
        Image bgMusicOff = GameObject.Find("BGMusicOff").GetComponent<Image>();
        
        Image soundsFXOn = GameObject.Find("SoundFXOn").GetComponent<Image>();
        Image soundsFXOff = GameObject.Find("SoundFXOff").GetComponent<Image>();

        //Determining seasons
        ChangeColorSeasonally a = gameObject.AddComponent<ChangeColorSeasonally>();
        int season = a.getSeason();

        //Cases for different seasons
        switch (season)
        {
            case 1:
                bgMusicOn.sprite = onButtonSpring;
                bgMusicOff.sprite = offButtonSpring;
                soundsFXOn.sprite = onButtonSpring;
                soundsFXOff.sprite = offButtonSpring;
                break;
            case 2:
                bgMusicOn.sprite = onButtonSummer;
                bgMusicOff.sprite = offButtonSummer;
                soundsFXOn.sprite = onButtonSummer;
                soundsFXOff.sprite = offButtonSummer;
                break;
            case 3:
                bgMusicOn.sprite = onButtonFall;
                bgMusicOff.sprite = offButtonFall;
                soundsFXOn.sprite = onButtonFall;
                soundsFXOff.sprite = offButtonFall;
                break;
            case 4:
                bgMusicOn.sprite = onButtonWinter;
                bgMusicOff.sprite = offButtonWinter;
                soundsFXOn.sprite = onButtonWinter;
                soundsFXOff.sprite = offButtonWinter;
                break;
        }
    }
}
