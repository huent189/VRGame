using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour {
    public void quit()
    {
        Application.Quit();
    }
    public void restart()
    {
        GameObject.Find("Player").GetComponent<Player>().reset();
    }
}
