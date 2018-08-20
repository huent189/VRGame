using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public TMPro.TextMeshPro textScore;
    public TMPro.TextMeshPro textClock;
    public TMPro.TextMeshPro txtEndGame;
    public TMPro.TextMeshPro txtRestart;
    public static int score = 0;
    private static float second = 60.00f;
    
    private bool isPlaying;
	// Use this for initialization
	void Start () {
        textScore.text = score.ToString();
        textClock.text = second.ToString("0.00");
        isPlaying = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(isPlaying)
        {
            if((second -= Time.deltaTime) <= 0)
            {
                isPlaying = false;
                textClock.text = "TIMEOUT";
                textScore.text = score.ToString();
                Instantiate(txtEndGame);
                Instantiate(txtRestart);
                txtEndGame.text = "Quit";
                txtRestart.text = "Restart";
            }
            else
            {
                textScore.text = score.ToString();
                textClock.text = second.ToString("0.00");
            }
        }         
    }
    public void reset()
    {
        Destroy(GameObject.FindGameObjectWithTag("end"));
        Destroy(GameObject.FindGameObjectWithTag("restart"));
        isPlaying = true;
        second = 60.00f;
        score = 0;
        textScore.text = score.ToString();
        textClock.text = second.ToString("0.00");
    }
}
