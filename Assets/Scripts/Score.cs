using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;

    public Text txt;

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score : "+score;
    }

    public void AddScore(int toAdd)
    {
        score += toAdd;
    }
}
