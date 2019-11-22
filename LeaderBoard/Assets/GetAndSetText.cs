using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAndSetText : MonoBehaviour
{
    public InputField gettext;
    public Text showtext;

    public void setget()
    {

        showtext.text = "Input is : " + gettext.text;
    }
    
}
