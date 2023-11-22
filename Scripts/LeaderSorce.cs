using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderSorce : MonoBehaviour
{
    [Header("Child")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    public void Initiate(int rank, string name, int score)
    {
        nameText.text = name;
        scoreText.text = score.ToString();

    }
}
