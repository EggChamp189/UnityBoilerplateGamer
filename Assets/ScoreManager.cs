using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //public TextMeshPro text;
    public TMP_Text text;
    public int score = 0;

    void Start()
    {
        text.text = "Score: " + score;
    }

    public void IncreaseScore()
    {
        score += 100;
        text.text = "Score: " + score;
    }
}
