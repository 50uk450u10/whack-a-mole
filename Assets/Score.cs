using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;


    [SerializeField] TMP_Text score_Text;

    public int ScoreUp()
    {
        ++score;
        UpdateScore();
        return score;
    }

    public void UpdateScore()
    {
        score_Text.text = "Score: " + score;
    }
}
