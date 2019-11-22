using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class LeaderBoard : MonoBehaviour
{
    public Dictionary<string, int> leaderboard = new Dictionary<string, int>();

    public string uname;
    public int score;
    public int count = 1;

    public InputField namefield;
    public InputField scorefield;

    public Text score1;
    public Text score2;
    public Text score3;
    public Text num1;
    public Text num2;
    public Text num3;

    public Button add;

    public void AddButton()
    {
        uname = namefield.text;
        score = int.Parse(scorefield.text);
        leaderboard.Add(uname, score);

        var list = leaderboard.ToList();
        list = list.OrderBy(i => i.Value).ToList();
        list.Reverse();

        if(count == 1)
        {
            num1.text = list[0].Key;
            score1.text = list[0].Value.ToString();
            count++;
        }
        else if(count == 2)
        {
            num1.text = list[0].Key;
            score1.text = list[0].Value.ToString();
            num2.text = list[1].Key;
            score2.text = list[1].Value.ToString();
            count++;
        }
        else
        {
            num1.text = list[0].Key;
            score1.text = list[0].Value.ToString();
            num2.text = list[1].Key;
            score2.text = list[1].Value.ToString();
            num3.text = list[2].Key;
            score3.text = list[2].Value.ToString();
            count++;
        }



    }


}
