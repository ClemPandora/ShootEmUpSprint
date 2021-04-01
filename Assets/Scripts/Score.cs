using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;

    public int toLife = 1000;

    public Text txt;

    public PlayerHealth health;

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score : "+score;
    }

    public void AddScore(int toAdd)
    {
        score += toAdd;
        toLife -= toAdd;
        if (toLife <= 0)
        {
            toLife += 1000;
            health.HealthUp();
        }
    }
}
