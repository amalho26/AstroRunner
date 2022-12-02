using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score1;
    public TextMeshProUGUI score2;
    public TextMeshProUGUI score3;
    string first;
    string second;
    string third;

    void Read()
    {
        string path = "Assets/Leaderboard/leaderboard.txt";
        StreamReader reader = new StreamReader(path);
        first = reader.ReadLine();
        second = reader.ReadLine();
        third = reader.ReadLine();
        reader.Close();
    }

    // Update is called once per frame
    void Update()
    {
        Read();
        score1.text = first;
        score2.text = second;
        score3.text = third;
    }


}
